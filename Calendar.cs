using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calendar
{
    public partial class Calendar : Form
    {
        #region Properties
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        internal PlanData Jobs { get => jobs; set => jobs = value; }

        private List<String> dateOfWeek = new List<string>{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private PlanData jobs;
        private string filePath = "data.xml";
        #endregion
        public Calendar()
        {
            InitializeComponent();
            tmNotify.Start();
            LoadMatrix();
            try
            {
                Jobs = DeserializeFromXML(filePath)as PlanData;
            }
            catch
            {
                SetDefaultJob();
            }
            
        }

        void SetDefaultJob()
        {
            Jobs = new PlanData();
            Jobs.Job = new List<PlanItem>();
            Jobs.Job.Add(new PlanItem() 
            {
                CurrentDay=DateTime.Now,
                FromTime=new Point(4,0),
                ToTime=new Point(5,0),
                Job="Test",
                Status=PlanItem.listStatus[(int)EPlanItem.Coming]
            });
            Jobs.Job.Add(new PlanItem()
            {
                CurrentDay = DateTime.Now,
                FromTime = new Point(5, 0),
                ToTime = new Point(6, 0),
                Job = "Test",
                Status = PlanItem.listStatus[(int)EPlanItem.Coming]
            });
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
                    btn.Click += Btn_Click;
                    pnlMatrix.Controls.Add(btn);
                    matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Content.margin, oldBtn.Location.Y + Content.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year,dtpkDate.Value.Month,Convert.ToInt32((sender as Button).Text)),Jobs);
            daily.ShowDialog();
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
                    (Matrix[i][j] as Button).BackColor = Color.WhiteSmoke;
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

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, data);
            fs.Close();
            //System.Xml.Serialization.XmlSerializer writer =
            //new System.Xml.Serialization.XmlSerializer(typeof(PlanData));

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            //System.IO.FileStream file = System.IO.File.Create(path);

            //writer.Serialize(file, data);
            //file.Close();
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch(Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
                
            }
        }

        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Jobs, filePath);
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if (!ckbNotify.Checked)
                return;
            if (jobs == null||jobs.Job == null)
                    return;
            DateTime currentDay = DateTime.Now;
            List<PlanItem> todayWork = Jobs.Job.Where(p =>p.CurrentDay.Year==currentDay.Year&&p.CurrentDay.Month==currentDay.Month&&p.CurrentDay.Day==currentDay.Day).ToList();
            notifyIcon.ShowBalloonTip(Content.notifyTime,"My work",string.Format("You have {0} work(s) today",todayWork.Count),ToolTipIcon.Info);
        }

        private void nmNotify_ValueChanged(object sender, EventArgs e)
        {
            Content.notifyTime = (int)nmNotify.Value;
            tmNotify.Interval = Content.notifyTime * 60000;
        }

        private void ckbNotify_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = ckbNotify.Checked;
        }
    }
}
