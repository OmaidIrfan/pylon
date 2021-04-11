namespace Pylon
{
    partial class TMarks
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.course1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.section1 = new System.Windows.Forms.ComboBox();
            this.category1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Aupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Search1 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(67, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(971, 70);
            this.panel5.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.course1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.section1);
            this.panel3.Controls.Add(this.category1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 61);
            this.panel3.TabIndex = 0;
            // 
            // course1
            // 
            this.course1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.course1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.course1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course1.ForeColor = System.Drawing.SystemColors.Info;
            this.course1.FormattingEnabled = true;
            this.course1.Location = new System.Drawing.Point(729, 23);
            this.course1.Name = "course1";
            this.course1.Size = new System.Drawing.Size(161, 24);
            this.course1.TabIndex = 10;
            this.course1.SelectedIndexChanged += new System.EventHandler(this.course1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Course:";
            // 
            // section1
            // 
            this.section1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.section1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.section1.ForeColor = System.Drawing.SystemColors.Info;
            this.section1.FormattingEnabled = true;
            this.section1.Items.AddRange(new object[] {
            "A",
            "B"});
            this.section1.Location = new System.Drawing.Point(459, 26);
            this.section1.Name = "section1";
            this.section1.Size = new System.Drawing.Size(121, 21);
            this.section1.TabIndex = 7;
            this.section1.SelectedIndexChanged += new System.EventHandler(this.section1_SelectedIndexChanged);
            // 
            // category1
            // 
            this.category1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.category1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.category1.ForeColor = System.Drawing.SystemColors.Info;
            this.category1.FormattingEnabled = true;
            this.category1.Items.AddRange(new object[] {
            "Quiz 01",
            "Assignment 01",
            "Mid 01",
            "Quiz 02",
            "Assignment 02",
            "Mid 02",
            "Project",
            "Final"});
            this.category1.Location = new System.Drawing.Point(171, 26);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(121, 21);
            this.category1.TabIndex = 6;
            this.category1.SelectedIndexChanged += new System.EventHandler(this.category1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Section:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // Aupdate
            // 
            this.Aupdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Aupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aupdate.Location = new System.Drawing.Point(530, 22);
            this.Aupdate.Name = "Aupdate";
            this.Aupdate.Size = new System.Drawing.Size(431, 33);
            this.Aupdate.TabIndex = 8;
            this.Aupdate.Text = "Update";
            this.Aupdate.UseVisualStyleBackColor = false;
            this.Aupdate.Click += new System.EventHandler(this.Aupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(971, 439);
            this.dataGridView1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 642);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1090, 67);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Search1
            // 
            this.Search1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Search1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search1.Location = new System.Drawing.Point(109, 22);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(415, 33);
            this.Search1.TabIndex = 9;
            this.Search1.Text = "Search";
            this.Search1.UseVisualStyleBackColor = false;
            this.Search1.Click += new System.EventHandler(this.Search1_Click);
            // 
            // TMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Search1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Aupdate);
            this.Controls.Add(this.panel5);
            this.Name = "TMarks";
            this.Size = new System.Drawing.Size(1102, 709);
            this.Load += new System.EventHandler(this.TMarks_Load);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Aupdate;
        private System.Windows.Forms.ComboBox section1;
        private System.Windows.Forms.ComboBox category1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox course1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search1;
    }
}
