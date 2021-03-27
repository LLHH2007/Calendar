using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class AJob : UserControl
    {
        public PlanItem Item { get => item; set => item = value; }
        private PlanItem item;

        private event EventHandler edited;
        public event EventHandler Editted
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        public AJob(PlanItem item)
        {
            InitializeComponent();
            this.Item = item;
            ShowInfo();
        }

        void ShowInfo()
        {
            txtJob.Text = Item.Job;
            nmFromHour.Value = item.FromTime.X;
            nmFromMin.Value = item.FromTime.Y;
            nmToHour.Value = item.ToTime.X;
            nmToMin.Value = item.ToTime.Y;
            cbxStatus.SelectedIndex = PlanItem.listStatus.IndexOf(item.Status);
            cbxDone.Checked = PlanItem.listStatus.IndexOf(Item.Status) == (int)EPlanItem.Done ? true : false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Item.Job = txtJob.Text;
            Item.FromTime = new Point((int)nmFromHour.Value, (int)nmFromMin.Value);
            Item.ToTime = new Point((int)nmToHour.Value, (int)nmToMin.Value);
            Item.Status = PlanItem.listStatus[cbxStatus.SelectedIndex];
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void cbxDone_CheckedChanged(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = cbxDone.Checked ? (int)EPlanItem.Done : (int)EPlanItem.Doing;
        }
    }
}
