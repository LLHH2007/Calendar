
namespace Calendar
{
    partial class Calendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 699);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(17, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 45);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 45);
            this.panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            this.nmNotify.Location = new System.Drawing.Point(74, 10);
            this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(120, 23);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Location = new System.Drawing.Point(9, 11);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(59, 19);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Notify";
            this.ckbNotify.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(512, 13);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(288, 11);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 23);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnNextMonth);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnThursday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnPrevMonth);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(17, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 71);
            this.panel4.TabIndex = 0;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(442, 23);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 23);
            this.btnFriday.TabIndex = 0;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(195, 23);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 23);
            this.btnTuesday.TabIndex = 0;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(685, 23);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(75, 23);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.Text = "Next Month";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(604, 23);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 23);
            this.btnSunday.TabIndex = 0;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(357, 23);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 23);
            this.btnThursday.TabIndex = 0;
            this.btnThursday.Text = "Thurday";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(523, 23);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 23);
            this.btnSaturday.TabIndex = 0;
            this.btnSaturday.Text = "Saturday";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(276, 23);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 23);
            this.btnWednesday.TabIndex = 0;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(33, 23);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(75, 23);
            this.btnPrevMonth.TabIndex = 0;
            this.btnPrevMonth.Text = "Prev Month";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(114, 23);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 23);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Location = new System.Drawing.Point(17, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 635);
            this.panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(76, 130);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(663, 505);
            this.pnlMatrix.TabIndex = 1;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 735);
            this.Controls.Add(this.panel1);
            this.Name = "Calendar";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
    }
}

