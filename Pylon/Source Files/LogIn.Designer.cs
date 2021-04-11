namespace Pylon
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.T1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // T1
            // 
            this.T1.AutoSize = true;
            this.T1.BackColor = System.Drawing.Color.Transparent;
            this.T1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1.ForeColor = System.Drawing.Color.PowderBlue;
            this.T1.Location = new System.Drawing.Point(144, 123);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(140, 49);
            this.T1.TabIndex = 2;
            this.T1.Text = "LOGIN";
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignIn.BackgroundImage")));
            this.SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignIn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignIn.Location = new System.Drawing.Point(134, 369);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(150, 32);
            this.SignIn.TabIndex = 3;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.PaleTurquoise;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(111, 248);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(196, 22);
            this.username.TabIndex = 6;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged_1);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.PaleTurquoise;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(111, 302);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(196, 20);
            this.password.TabIndex = 8;
            this.password.UseSystemPasswordChar = true;
            this.password.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.password_MaskInputRejected);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(313, 309);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "show password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Pylon.Properties.Resources.Screenshot_2019_12_03_password_and_username___Google_Search;
            this.pictureBox1.Location = new System.Drawing.Point(73, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Pylon.Properties.Resources.Screenshot_2019_12_03_password_and_username___Google_Search_1_;
            this.pictureBox2.Location = new System.Drawing.Point(73, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Pylon.Properties.Resources.P1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 519);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.T1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pylon";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label T1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}