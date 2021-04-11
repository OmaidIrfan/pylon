namespace Pylon
{
    partial class SHOME
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
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.sTranscript1 = new Pylon.STranscript();
            this.sAttendence1 = new Pylon.SAttendence();
            this.sMarks1 = new Pylon.SMarks();
            this.sHomeHome1 = new Pylon.Source_Files.SHomeHome();
            this.sRegistration1 = new Pylon.SRegistration();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.panel2.Controls.Add(this.p5);
            this.panel2.Controls.Add(this.p3);
            this.panel2.Controls.Add(this.p4);
            this.panel2.Controls.Add(this.p2);
            this.panel2.Controls.Add(this.p1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 526);
            this.panel2.TabIndex = 1;
            // 
            // p5
            // 
            this.p5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p5.Image = global::Pylon.Properties.Resources.Registration;
            this.p5.Location = new System.Drawing.Point(4, 434);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(151, 87);
            this.p5.TabIndex = 6;
            this.p5.TabStop = false;
            this.p5.Click += new System.EventHandler(this.p5_Click);
            // 
            // p3
            // 
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3.Image = global::Pylon.Properties.Resources.Attendence;
            this.p3.Location = new System.Drawing.Point(2, 228);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(151, 87);
            this.p3.TabIndex = 5;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // p4
            // 
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4.Image = global::Pylon.Properties.Resources.Transcript;
            this.p4.Location = new System.Drawing.Point(3, 333);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(151, 87);
            this.p4.TabIndex = 4;
            this.p4.TabStop = false;
            this.p4.Click += new System.EventHandler(this.p4_Click);
            // 
            // p2
            // 
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2.Image = global::Pylon.Properties.Resources.Marks;
            this.p2.Location = new System.Drawing.Point(4, 118);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(151, 87);
            this.p2.TabIndex = 3;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // p1
            // 
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Image = global::Pylon.Properties.Resources.Home;
            this.p1.Location = new System.Drawing.Point(3, 14);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(151, 87);
            this.p1.TabIndex = 2;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // sTranscript1
            // 
            this.sTranscript1.AutoScroll = true;
            this.sTranscript1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTranscript1.Location = new System.Drawing.Point(160, 55);
            this.sTranscript1.Name = "sTranscript1";
            this.sTranscript1.Size = new System.Drawing.Size(1107, 526);
            this.sTranscript1.TabIndex = 5;
            // 
            // sAttendence1
            // 
            this.sAttendence1.AutoScroll = true;
            this.sAttendence1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sAttendence1.Location = new System.Drawing.Point(160, 55);
            this.sAttendence1.Name = "sAttendence1";
            this.sAttendence1.Size = new System.Drawing.Size(1107, 526);
            this.sAttendence1.TabIndex = 4;
            // 
            // sMarks1
            // 
            this.sMarks1.AutoScroll = true;
            this.sMarks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sMarks1.Location = new System.Drawing.Point(160, 55);
            this.sMarks1.Name = "sMarks1";
            this.sMarks1.Size = new System.Drawing.Size(1107, 526);
            this.sMarks1.TabIndex = 3;
            // 
            // sHomeHome1
            // 
            this.sHomeHome1.AutoScroll = true;
            this.sHomeHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sHomeHome1.Location = new System.Drawing.Point(160, 55);
            this.sHomeHome1.Name = "sHomeHome1";
            this.sHomeHome1.Size = new System.Drawing.Size(1107, 526);
            this.sHomeHome1.TabIndex = 2;
            this.sHomeHome1.Load += new System.EventHandler(this.sHomeHome1_Load);
            // 
            // sRegistration1
            // 
            this.sRegistration1.AutoScroll = true;
            this.sRegistration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sRegistration1.Location = new System.Drawing.Point(160, 55);
            this.sRegistration1.Name = "sRegistration1";
            this.sRegistration1.Size = new System.Drawing.Size(1107, 526);
            this.sRegistration1.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(987, 21);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SHOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 581);
            this.Controls.Add(this.sRegistration1);
            this.Controls.Add(this.sTranscript1);
            this.Controls.Add(this.sAttendence1);
            this.Controls.Add(this.sMarks1);
            this.Controls.Add(this.sHomeHome1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SHOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOME";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private Source_Files.SHomeHome sHomeHome1;
        private SMarks sMarks1;
        private SAttendence sAttendence1;
        private STranscript sTranscript1;
        private SRegistration sRegistration1;
        private System.Windows.Forms.Button Exit;
    }
}