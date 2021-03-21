using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Calendar : Form
    {
        #region Properties
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        internal PlanData Job { get => job; set => job = value; }

        private List<String> dateOfWeek = new List<string>{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private PlanData job;
        #endregion
        public Calendar()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Content.margin, 0) };
            for (int i = 0; i < Content.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Content.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Content.dateButtonWidth, Height = Content.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Content.margin, oldBtn.Location.Y);
                    pnlMatrix.Controls.Add(btn);
                    matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Content.margin, oldBtn.Location.Y + Content.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                    {
                        return 29;
                    }
                    return 28;
                default:
                    return 30;
            }
        }

        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (isEqualDate(useDate,DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }


        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for(int j = 0; j < Matrix[i].Count; j++)
                {
                    Matrix[i][j].Text = "";
                    btnFriday.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        
    }
}
