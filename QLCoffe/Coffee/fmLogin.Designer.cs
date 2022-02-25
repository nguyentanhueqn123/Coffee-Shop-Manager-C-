namespace Coffee
{
    partial class fmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picPassWord = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSighup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassWord)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.White;
            this.txbPassword.HideSelection = false;
            this.txbPassword.Location = new System.Drawing.Point(67, 243);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(221, 27);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.TabStop = false;
            this.txbPassword.Text = "Password";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.White;
            this.txbUsername.HideSelection = false;
            this.txbUsername.Location = new System.Drawing.Point(67, 172);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(231, 27);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.TabStop = false;
            this.txbUsername.Text = "Username";
            this.txbUsername.Click += new System.EventHandler(this.txbUsername_Click);
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnSighup);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.txbUsername);
            this.panel1.Controls.Add(this.picUsername);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.picPassWord);
            this.panel1.Location = new System.Drawing.Point(573, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 429);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(33, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(33, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 2);
            this.panel2.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Coffee.Properties.Resources._70b42c532dc7e599bcd6;
            this.picLogo.Location = new System.Drawing.Point(104, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(116, 114);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.Image = global::Coffee.Properties.Resources.account_circle;
            this.picUsername.Location = new System.Drawing.Point(23, 165);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(40, 39);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsername.TabIndex = 2;
            this.picUsername.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnLogin.Location = new System.Drawing.Point(33, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picPassWord
            // 
            this.picPassWord.BackColor = System.Drawing.Color.Transparent;
            this.picPassWord.Image = global::Coffee.Properties.Resources.lock_1;
            this.picPassWord.Location = new System.Drawing.Point(21, 231);
            this.picPassWord.Name = "picPassWord";
            this.picPassWord.Size = new System.Drawing.Size(40, 40);
            this.picPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassWord.TabIndex = 1;
            this.picPassWord.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(773, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcom to KingMeta Coffee";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSighup
            // 
            this.btnSighup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSighup.BackgroundImage")));
            this.btnSighup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSighup.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSighup.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSighup.Location = new System.Drawing.Point(33, 357);
            this.btnSighup.Name = "btnSighup";
            this.btnSighup.Size = new System.Drawing.Size(255, 46);
            this.btnSighup.TabIndex = 7;
            this.btnSighup.Text = "Sigh up";
            this.btnSighup.UseVisualStyleBackColor = true;
            this.btnSighup.Click += new System.EventHandler(this.btnSighup_Click);
            // 
            // fmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee.Properties.Resources.backgroundCaffe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.PictureBox picPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSighup;
    }
}