
namespace Coffee
{
    partial class fmSighup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSighup));
            this.btnSignup = new System.Windows.Forms.Button();
            this.txbRePassword = new System.Windows.Forms.TextBox();
            this.lbRePassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbDisplayname = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.rdbStaff = new System.Windows.Forms.RadioButton();
            this.lbDisplayname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Red;
            this.btnSignup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignup.BackgroundImage")));
            this.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignup.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSignup.Location = new System.Drawing.Point(203, 402);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(282, 70);
            this.btnSignup.TabIndex = 49;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txbRePassword
            // 
            this.txbRePassword.BackColor = System.Drawing.Color.White;
            this.txbRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRePassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRePassword.ForeColor = System.Drawing.Color.Black;
            this.txbRePassword.HideSelection = false;
            this.txbRePassword.Location = new System.Drawing.Point(203, 320);
            this.txbRePassword.Name = "txbRePassword";
            this.txbRePassword.Size = new System.Drawing.Size(282, 27);
            this.txbRePassword.TabIndex = 48;
            this.txbRePassword.TabStop = false;
            this.txbRePassword.UseSystemPasswordChar = true;
            // 
            // lbRePassword
            // 
            this.lbRePassword.AutoSize = true;
            this.lbRePassword.BackColor = System.Drawing.Color.Transparent;
            this.lbRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePassword.Location = new System.Drawing.Point(22, 320);
            this.lbRePassword.Name = "lbRePassword";
            this.lbRePassword.Size = new System.Drawing.Size(165, 29);
            this.lbRePassword.TabIndex = 47;
            this.lbRePassword.Text = "Re-Password:";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.Black;
            this.txbPassword.HideSelection = false;
            this.txbPassword.Location = new System.Drawing.Point(203, 273);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(282, 27);
            this.txbPassword.TabIndex = 46;
            this.txbPassword.TabStop = false;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbDisplayname
            // 
            this.txbDisplayname.BackColor = System.Drawing.Color.White;
            this.txbDisplayname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayname.ForeColor = System.Drawing.Color.Black;
            this.txbDisplayname.HideSelection = false;
            this.txbDisplayname.Location = new System.Drawing.Point(203, 214);
            this.txbDisplayname.Name = "txbDisplayname";
            this.txbDisplayname.Size = new System.Drawing.Size(282, 34);
            this.txbDisplayname.TabIndex = 44;
            this.txbDisplayname.TabStop = false;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.White;
            this.txbUsername.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txbUsername.ForeColor = System.Drawing.Color.Black;
            this.txbUsername.HideSelection = false;
            this.txbUsername.Location = new System.Drawing.Point(203, 162);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(282, 34);
            this.txbUsername.TabIndex = 43;
            this.txbUsername.TabStop = false;
            // 
            // rdbStaff
            // 
            this.rdbStaff.AutoSize = true;
            this.rdbStaff.BackColor = System.Drawing.Color.Transparent;
            this.rdbStaff.Enabled = false;
            this.rdbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStaff.Location = new System.Drawing.Point(203, 363);
            this.rdbStaff.Name = "rdbStaff";
            this.rdbStaff.Size = new System.Drawing.Size(141, 33);
            this.rdbStaff.TabIndex = 41;
            this.rdbStaff.TabStop = true;
            this.rdbStaff.Text = "Nhân viên";
            this.rdbStaff.UseVisualStyleBackColor = false;
            // 
            // lbDisplayname
            // 
            this.lbDisplayname.AutoSize = true;
            this.lbDisplayname.BackColor = System.Drawing.Color.Transparent;
            this.lbDisplayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayname.Location = new System.Drawing.Point(22, 219);
            this.lbDisplayname.Name = "lbDisplayname";
            this.lbDisplayname.Size = new System.Drawing.Size(169, 29);
            this.lbDisplayname.TabIndex = 40;
            this.lbDisplayname.Text = "Display Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee.Properties.Resources._70b42c532dc7e599bcd6;
            this.pictureBox1.Location = new System.Drawing.Point(265, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(22, 273);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(126, 29);
            this.lbPassword.TabIndex = 45;
            this.lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(22, 163);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(130, 29);
            this.lbUsername.TabIndex = 39;
            this.lbUsername.Text = "Username:";
            // 
            // fmSighup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txbRePassword);
            this.Controls.Add(this.lbRePassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txbDisplayname);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.rdbStaff);
            this.Controls.Add(this.lbDisplayname);
            this.Controls.Add(this.lbUsername);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmSighup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmSighup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txbRePassword;
        private System.Windows.Forms.Label lbRePassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbDisplayname;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.RadioButton rdbStaff;
        private System.Windows.Forms.Label lbDisplayname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
    }
}