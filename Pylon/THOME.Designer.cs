namespace Pylon
{
    partial class THOME
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.PictureBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.tAttendence1 = new Pylon.TAttendence();
            this.tHomeHome1 = new Pylon.THomeHome();
            this.tMarks1 = new Pylon.TMarks();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 55);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Pylon.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.p9);
            this.panel2.Controls.Add(this.p8);
            this.panel2.Controls.Add(this.p7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 526);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(4, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 87);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(3, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 87);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // p9
            // 
            this.p9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p9.Image = global::Pylon.Properties.Resources.Attendence;
            this.p9.Location = new System.Drawing.Point(3, 218);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(151, 87);
            this.p9.TabIndex = 5;
            this.p9.TabStop = false;
            this.p9.Click += new System.EventHandler(this.p9_Click);
            // 
            // p8
            // 
            this.p8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p8.Image = global::Pylon.Properties.Resources.Marks;
            this.p8.Location = new System.Drawing.Point(3, 113);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(151, 87);
            this.p8.TabIndex = 3;
            this.p8.TabStop = false;
            this.p8.Click += new System.EventHandler(this.p8_Click);
            // 
            // p7
            // 
            this.p7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p7.Image = global::Pylon.Properties.Resources.Home;
            this.p7.Location = new System.Drawing.Point(4, 9);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(151, 87);
            this.p7.TabIndex = 2;
            this.p7.TabStop = false;
            this.p7.Click += new System.EventHandler(this.p7_Click);
            // 
            // tAttendence1
            // 
            this.tAttendence1.AutoScroll = true;
            this.tAttendence1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAttendence1.Location = new System.Drawing.Point(160, 55);
            this.tAttendence1.Name = "tAttendence1";
            this.tAttendence1.Size = new System.Drawing.Size(1107, 526);
            this.tAttendence1.TabIndex = 5;
            // 
            // tHomeHome1
            // 
            this.tHomeHome1.AutoScroll = true;
            this.tHomeHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tHomeHome1.Location = new System.Drawing.Point(160, 55);
            this.tHomeHome1.Name = "tHomeHome1";
            this.tHomeHome1.Size = new System.Drawing.Size(1107, 526);
            this.tHomeHome1.TabIndex = 4;
            // 
            // tMarks1
            // 
            this.tMarks1.AutoScroll = true;
            this.tMarks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMarks1.Location = new System.Drawing.Point(160, 55);
            this.tMarks1.Name = "tMarks1";
            this.tMarks1.Size = new System.Drawing.Size(1107, 526);
            this.tMarks1.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(989, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // THOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 581);
            this.Controls.Add(this.tMarks1);
            this.Controls.Add(this.tAttendence1);
            this.Controls.Add(this.tHomeHome1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "THOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THOME";
            this.Load += new System.EventHandler(this.THOME_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox p9;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private THomeHome tHomeHome1;
        private TAttendence tAttendence1;
        private TMarks tMarks1;
        private System.Windows.Forms.Button Exit;
    }
}