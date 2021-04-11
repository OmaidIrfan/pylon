namespace Pylon
{
    partial class AHomeHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search1 = new System.Windows.Forms.Button();
            this.ID1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sHomeHome2 = new Pylon.Source_Files.SHomeHome();
            this.tHomeHome2 = new Pylon.THomeHome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(107, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.search1);
            this.panel2.Controls.Add(this.ID1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.select);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 64);
            this.panel2.TabIndex = 0;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.search1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.Location = new System.Drawing.Point(662, 17);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(133, 30);
            this.search1.TabIndex = 9;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // ID1
            // 
            this.ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID1.Location = new System.Drawing.Point(435, 25);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(100, 22);
            this.ID1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID:";
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.DarkSlateGray;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.select.Location = new System.Drawing.Point(174, 25);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(143, 21);
            this.select.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category:";
            // 
            // sHomeHome2
            // 
            this.sHomeHome2.AutoScroll = true;
            this.sHomeHome2.Location = new System.Drawing.Point(0, 123);
            this.sHomeHome2.Name = "sHomeHome2";
            this.sHomeHome2.Size = new System.Drawing.Size(1092, 980);
            this.sHomeHome2.TabIndex = 2;
            this.sHomeHome2.Load += new System.EventHandler(this.sHomeHome2_Load);
            // 
            // tHomeHome2
            // 
            this.tHomeHome2.AutoScroll = true;
            this.tHomeHome2.Location = new System.Drawing.Point(0, 119);
            this.tHomeHome2.Name = "tHomeHome2";
            this.tHomeHome2.Size = new System.Drawing.Size(1092, 972);
            this.tHomeHome2.TabIndex = 1;
            // 
            // AHomeHome
            // 
            this.Controls.Add(this.sHomeHome2);
            this.Controls.Add(this.tHomeHome2);
            this.Controls.Add(this.panel1);
            this.Name = "AHomeHome";
            this.Size = new System.Drawing.Size(1092, 1088);
            this.Load += new System.EventHandler(this.AHomeHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Aupdate;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private THomeHome tHomeHome1;
        private Source_Files.SHomeHome sHomeHome1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.TextBox ID1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox select;
        private THomeHome tHomeHome2;
        private Source_Files.SHomeHome sHomeHome2;
    }
}
