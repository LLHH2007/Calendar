
namespace Calendar
{
    partial class AJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.nmToMin = new System.Windows.Forms.NumericUpDown();
            this.nmToHour = new System.Windows.Forms.NumericUpDown();
            this.nmFromMin = new System.Windows.Forms.NumericUpDown();
            this.nmFromHour = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.cbxDone = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHour)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.cbxStatus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.To);
            this.panel3.Controls.Add(this.nmToMin);
            this.panel3.Controls.Add(this.nmToHour);
            this.panel3.Controls.Add(this.nmFromMin);
            this.panel3.Controls.Add(this.nmFromHour);
            this.panel3.Location = new System.Drawing.Point(587, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 40);
            this.panel3.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(668, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(576, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.DisplayMember = "Done,Doing,Coming,Missed";
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Done",
            "Doing",
            "Coming",
            "Missed"});
            this.cbxStatus.Location = new System.Drawing.Point(430, 10);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 2;
            this.cbxStatus.ValueMember = "Done,Doing,Coming,Missed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "h";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(180, 12);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(20, 15);
            this.To.TabIndex = 1;
            this.To.Text = "To";
            // 
            // nmToMin
            // 
            this.nmToMin.Location = new System.Drawing.Point(334, 10);
            this.nmToMin.Name = "nmToMin";
            this.nmToMin.Size = new System.Drawing.Size(63, 23);
            this.nmToMin.TabIndex = 0;
            // 
            // nmToHour
            // 
            this.nmToHour.Location = new System.Drawing.Point(216, 7);
            this.nmToHour.Name = "nmToHour";
            this.nmToHour.Size = new System.Drawing.Size(58, 23);
            this.nmToHour.TabIndex = 0;
            // 
            // nmFromMin
            // 
            this.nmFromMin.Location = new System.Drawing.Point(113, 8);
            this.nmFromMin.Name = "nmFromMin";
            this.nmFromMin.Size = new System.Drawing.Size(48, 23);
            this.nmFromMin.TabIndex = 0;
            // 
            // nmFromHour
            // 
            this.nmFromHour.Location = new System.Drawing.Point(19, 7);
            this.nmFromHour.Name = "nmFromHour";
            this.nmFromHour.Size = new System.Drawing.Size(46, 23);
            this.nmFromHour.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtJob);
            this.panel2.Controls.Add(this.cbxDone);
            this.panel2.Location = new System.Drawing.Point(10, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 40);
            this.panel2.TabIndex = 2;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(35, 10);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(525, 23);
            this.txtJob.TabIndex = 1;
            // 
            // cbxDone
            // 
            this.cbxDone.AutoSize = true;
            this.cbxDone.Location = new System.Drawing.Point(14, 14);
            this.cbxDone.Name = "cbxDone";
            this.cbxDone.Size = new System.Drawing.Size(15, 14);
            this.cbxDone.TabIndex = 0;
            this.cbxDone.UseVisualStyleBackColor = true;
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(1344, 69);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.NumericUpDown nmToMin;
        private System.Windows.Forms.NumericUpDown nmToHour;
        private System.Windows.Forms.NumericUpDown nmFromMin;
        private System.Windows.Forms.NumericUpDown nmFromHour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox cbxDone;
    }
}