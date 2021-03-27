using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData job;
        public DateTime Date { get => date; set => date = value; }
        public PlanData Job { get => job; set => job = value; }
        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;
            dtpkDate.Value = Date;
            mnsAddwork.Click += MnsAddwork_Click;
            mnsToday.Click += MnsToday_Click;
        }

        private void MnsToday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void MnsAddwork_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() {CurrentDay=dtpkDate.Value, Job="Insert job here",ToTime=new Point(1,1), Status="Coming"};
            Job.Job.Add(item);
            AddJob(item);
        }

        void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Deleted += AJob_Deleted;
            aJob.Editted += AJob_Editted;
            fPanel.Controls.Add(aJob);
        }

        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (job != null && job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDate(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
            
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);
        }

        private void AJob_Editted(object sender, EventArgs e)
        {
            
        }

        private void AJob_Deleted(object sender, EventArgs e)
        {
            AJob userControl = sender as AJob;
            PlanItem job = userControl.Item;
            fPanel.Controls.Remove(userControl);
            Job.Job.Remove(job);
        }

        List<PlanItem> GetJobByDate(DateTime date)
        {
            return job.Job.Where(p => p.CurrentDay.Year == date.Year && p.CurrentDay.Month == date.Month && p.CurrentDay.Day == date.Day).ToList();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnPrevDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

    }
}
