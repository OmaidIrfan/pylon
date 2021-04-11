namespace Pylon
{
    partial class TAttendence
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.course2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.section2 = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search1 = new System.Windows.Forms.Button();
            this.Aupdate = new System.Windows.Forms.Button();
            this.Create1 = new System.Windows.Forms.Button();
            this.Add1 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 877);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1090, 67);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(54, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 70);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.course2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.section2);
            this.panel3.Controls.Add(this.month);
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 61);
            this.panel3.TabIndex = 0;
            // 
            // course2
            // 
            this.course2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.course2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.course2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course2.ForeColor = System.Drawing.SystemColors.Info;
            this.course2.FormattingEnabled = true;
            this.course2.Location = new System.Drawing.Point(833, 21);
            this.course2.Name = "course2";
            this.course2.Size = new System.Drawing.Size(161, 24);
            this.course2.TabIndex = 11;
            this.course2.SelectedIndexChanged += new System.EventHandler(this.course2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Course:";
            // 
            // section2
            // 
            this.section2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.section2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.section2.ForeColor = System.Drawing.SystemColors.Info;
            this.section2.FormattingEnabled = true;
            this.section2.Items.AddRange(new object[] {
            "A",
            "B"});
            this.section2.Location = new System.Drawing.Point(580, 24);
            this.section2.Name = "section2";
            this.section2.Size = new System.Drawing.Size(121, 21);
            this.section2.TabIndex = 7;
            this.section2.SelectedIndexChanged += new System.EventHandler(this.section2_SelectedIndexChanged);
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.DarkSlateGray;
            this.month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.month.ForeColor = System.Drawing.SystemColors.Info;
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month.Location = new System.Drawing.Point(102, 24);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(121, 21);
            this.month.TabIndex = 6;
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.DarkSlateGray;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.date.ForeColor = System.Drawing.SystemColors.Info;
            this.date.FormattingEnabled = true;
            this.date.Items.AddRange(new object[] {
            "01/19",
            "02/19",
            "03/19",
            "04/19",
            "05/19",
            "06/19",
            "07/19",
            "08/19",
            "09/19",
            "10/19",
            "11/19",
            "12/19",
            "13/19",
            "14/19",
            "15/19",
            "16/19",
            "17/19",
            "18/19",
            "19/19",
            "20/19",
            "21/19",
            "22/19",
            "23/19",
            "24/19",
            "25/19",
            "26/19",
            "27/19",
            "28/19",
            "29/19",
            "30/19",
            "31/19"});
            this.date.Location = new System.Drawing.Point(331, 24);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(121, 21);
            this.date.TabIndex = 5;
            this.date.SelectedIndexChanged += new System.EventHandler(this.date_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Section:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 668);
            this.dataGridView1.TabIndex = 5;
            // 
            // Search1
            // 
            this.Search1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Search1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search1.Location = new System.Drawing.Point(299, 30);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(199, 33);
            this.Search1.TabIndex = 10;
            this.Search1.Text = "Search";
            this.Search1.UseVisualStyleBackColor = false;
            this.Search1.Click += new System.EventHandler(this.Search1_Click);
            // 
            // Aupdate
            // 
            this.Aupdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Aupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aupdate.Location = new System.Drawing.Point(753, 30);
            this.Aupdate.Name = "Aupdate";
            this.Aupdate.Size = new System.Drawing.Size(213, 33);
            this.Aupdate.TabIndex = 11;
            this.Aupdate.Text = "Update";
            this.Aupdate.UseVisualStyleBackColor = false;
            this.Aupdate.Click += new System.EventHandler(this.Aupdate_Click);
            // 
            // Create1
            // 
            this.Create1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Create1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Create1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create1.Location = new System.Drawing.Point(72, 30);
            this.Create1.Name = "Create1";
            this.Create1.Size = new System.Drawing.Size(193, 33);
            this.Create1.TabIndex = 12;
            this.Create1.Text = "Create";
            this.Create1.UseVisualStyleBackColor = false;
            this.Create1.Click += new System.EventHandler(this.Create1_Click);
            // 
            // Add1
            // 
            this.Add1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add1.Location = new System.Drawing.Point(517, 30);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(210, 33);
            this.Add1.TabIndex = 13;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = false;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // TAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.Create1);
            this.Controls.Add(this.Aupdate);
            this.Controls.Add(this.Search1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TAttendence";
            this.Size = new System.Drawing.Size(1102, 944);
            this.Load += new System.EventHandler(this.TAttendence_Load);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox section2;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search1;
        private System.Windows.Forms.Button Aupdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox course2;
        private System.Windows.Forms.Button Create1;
        private System.Windows.Forms.Button Add1;
    }
}
