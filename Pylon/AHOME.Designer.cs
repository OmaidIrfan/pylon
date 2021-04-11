namespace Pylon
{
    partial class AHOME
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
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adHome = new System.Windows.Forms.Button();
            this.Freeze = new System.Windows.Forms.Button();
            this.CRegistration = new System.Windows.Forms.Button();
            this.TRegistrtion = new System.Windows.Forms.Button();
            this.SRegistration = new System.Windows.Forms.Button();
            this.acRegistration1 = new Pylon.ACRegistration();
            this.aHomeHome1 = new Pylon.AHomeHome();
            this.atRegistration1 = new Pylon.ATRegistration();
            this.asRegistration1 = new Pylon.ASRegistration();
            this.aFee1 = new Pylon.AFee();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(944, 21);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.panel2.Controls.Add(this.adHome);
            this.panel2.Controls.Add(this.Freeze);
            this.panel2.Controls.Add(this.CRegistration);
            this.panel2.Controls.Add(this.TRegistrtion);
            this.panel2.Controls.Add(this.SRegistration);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 526);
            this.panel2.TabIndex = 2;
            // 
            // adHome
            // 
            this.adHome.BackColor = System.Drawing.Color.SeaGreen;
            this.adHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adHome.Location = new System.Drawing.Point(3, 9);
            this.adHome.Name = "adHome";
            this.adHome.Size = new System.Drawing.Size(152, 80);
            this.adHome.TabIndex = 4;
            this.adHome.Text = "Home";
            this.adHome.UseVisualStyleBackColor = false;
            this.adHome.Click += new System.EventHandler(this.adHome_Click);
            // 
            // Freeze
            // 
            this.Freeze.BackColor = System.Drawing.Color.SeaGreen;
            this.Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freeze.Location = new System.Drawing.Point(3, 433);
            this.Freeze.Name = "Freeze";
            this.Freeze.Size = new System.Drawing.Size(152, 80);
            this.Freeze.TabIndex = 5;
            this.Freeze.Text = "Freeze Semester";
            this.Freeze.UseVisualStyleBackColor = false;
            this.Freeze.Click += new System.EventHandler(this.fee_Click);
            // 
            // CRegistration
            // 
            this.CRegistration.BackColor = System.Drawing.Color.SeaGreen;
            this.CRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRegistration.Location = new System.Drawing.Point(3, 328);
            this.CRegistration.Name = "CRegistration";
            this.CRegistration.Size = new System.Drawing.Size(152, 80);
            this.CRegistration.TabIndex = 5;
            this.CRegistration.Text = "Course Registration";
            this.CRegistration.UseVisualStyleBackColor = false;
            this.CRegistration.Click += new System.EventHandler(this.CRegistration_Click);
            // 
            // TRegistrtion
            // 
            this.TRegistrtion.BackColor = System.Drawing.Color.SeaGreen;
            this.TRegistrtion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TRegistrtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRegistrtion.Location = new System.Drawing.Point(3, 219);
            this.TRegistrtion.Name = "TRegistrtion";
            this.TRegistrtion.Size = new System.Drawing.Size(152, 80);
            this.TRegistrtion.TabIndex = 4;
            this.TRegistrtion.Text = "Teacher Registration";
            this.TRegistrtion.UseVisualStyleBackColor = false;
            this.TRegistrtion.Click += new System.EventHandler(this.TRegistrtion_Click);
            // 
            // SRegistration
            // 
            this.SRegistration.BackColor = System.Drawing.Color.SeaGreen;
            this.SRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRegistration.Location = new System.Drawing.Point(3, 107);
            this.SRegistration.Name = "SRegistration";
            this.SRegistration.Size = new System.Drawing.Size(152, 80);
            this.SRegistration.TabIndex = 3;
            this.SRegistration.Text = "Student Registration";
            this.SRegistration.UseVisualStyleBackColor = false;
            this.SRegistration.Click += new System.EventHandler(this.SRegistration_Click);
            // 
            // acRegistration1
            // 
            this.acRegistration1.AutoScroll = true;
            this.acRegistration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acRegistration1.Location = new System.Drawing.Point(160, 55);
            this.acRegistration1.Name = "acRegistration1";
            this.acRegistration1.Size = new System.Drawing.Size(1107, 526);
            this.acRegistration1.TabIndex = 6;
            // 
            // aHomeHome1
            // 
            this.aHomeHome1.AutoScroll = true;
            this.aHomeHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aHomeHome1.Location = new System.Drawing.Point(160, 55);
            this.aHomeHome1.Name = "aHomeHome1";
            this.aHomeHome1.Size = new System.Drawing.Size(1107, 526);
            this.aHomeHome1.TabIndex = 5;
            // 
            // atRegistration1
            // 
            this.atRegistration1.AutoScroll = true;
            this.atRegistration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atRegistration1.Location = new System.Drawing.Point(160, 55);
            this.atRegistration1.Name = "atRegistration1";
            this.atRegistration1.Size = new System.Drawing.Size(1107, 526);
            this.atRegistration1.TabIndex = 4;
            // 
            // asRegistration1
            // 
            this.asRegistration1.AutoScroll = true;
            this.asRegistration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asRegistration1.Location = new System.Drawing.Point(160, 55);
            this.asRegistration1.Name = "asRegistration1";
            this.asRegistration1.Size = new System.Drawing.Size(1107, 526);
            this.asRegistration1.TabIndex = 3;
            // 
            // aFee1
            // 
            this.aFee1.AutoScroll = true;
            this.aFee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aFee1.Location = new System.Drawing.Point(160, 55);
            this.aFee1.Name = "aFee1";
            this.aFee1.Size = new System.Drawing.Size(1107, 526);
            this.aFee1.TabIndex = 7;
            // 
            // AHOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 581);
            this.Controls.Add(this.aFee1);
            this.Controls.Add(this.acRegistration1);
            this.Controls.Add(this.aHomeHome1);
            this.Controls.Add(this.atRegistration1);
            this.Controls.Add(this.asRegistration1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AHOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHOME";
            this.Load += new System.EventHandler(this.AHOME_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CRegistration;
        private System.Windows.Forms.Button TRegistrtion;
        private System.Windows.Forms.Button SRegistration;
        private System.Windows.Forms.Button adHome;
        private System.Windows.Forms.Button Freeze;
        private ASRegistration asRegistration1;
        private ATRegistration atRegistration1;
        private AHomeHome aHomeHome1;
        private ACRegistration acRegistration1;
        private AFee aFee1;
        private System.Windows.Forms.Button Exit;
    }
}