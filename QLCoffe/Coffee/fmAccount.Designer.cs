namespace Coffee
{
    partial class fmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAccount));
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbDisplayname = new System.Windows.Forms.TextBox();
            this.btnAcountAdd = new System.Windows.Forms.Button();
            this.btnAccountEdit = new System.Windows.Forms.Button();
            this.btnAccountDel = new System.Windows.Forms.Button();
            this.rdbStaff = new System.Windows.Forms.RadioButton();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvAccount.Location = new System.Drawing.Point(0, 217);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(693, 287);
            this.dtgvAccount.TabIndex = 0;
            this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
            // 
            // txbUsername
            // 
            this.txbUsername.Enabled = false;
            this.txbUsername.Location = new System.Drawing.Point(187, 12);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(320, 40);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.Text = "khoahieu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hiển thị";
            // 
            // txbPassword
            // 
            this.txbPassword.Enabled = false;
            this.txbPassword.Location = new System.Drawing.Point(187, 64);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(320, 40);
            this.txbPassword.TabIndex = 5;
            this.txbPassword.Text = "23456";
            // 
            // txbDisplayname
            // 
            this.txbDisplayname.Enabled = false;
            this.txbDisplayname.Location = new System.Drawing.Point(187, 124);
            this.txbDisplayname.Name = "txbDisplayname";
            this.txbDisplayname.Size = new System.Drawing.Size(320, 40);
            this.txbDisplayname.TabIndex = 6;
            this.txbDisplayname.Text = "khoahie";
            // 
            // btnAcountAdd
            // 
            this.btnAcountAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAcountAdd.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnAcountAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcountAdd.Location = new System.Drawing.Point(528, 12);
            this.btnAcountAdd.Name = "btnAcountAdd";
            this.btnAcountAdd.Size = new System.Drawing.Size(150, 45);
            this.btnAcountAdd.TabIndex = 7;
            this.btnAcountAdd.Text = "Thêm";
            this.btnAcountAdd.UseVisualStyleBackColor = false;
            this.btnAcountAdd.Click += new System.EventHandler(this.btnAcountAdd_Click);
            // 
            // btnAccountEdit
            // 
            this.btnAccountEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAccountEdit.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnAccountEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccountEdit.Location = new System.Drawing.Point(528, 65);
            this.btnAccountEdit.Name = "btnAccountEdit";
            this.btnAccountEdit.Size = new System.Drawing.Size(150, 45);
            this.btnAccountEdit.TabIndex = 8;
            this.btnAccountEdit.Text = "Sửa";
            this.btnAccountEdit.UseVisualStyleBackColor = false;
            this.btnAccountEdit.Click += new System.EventHandler(this.btnAccountEdit_Click);
            // 
            // btnAccountDel
            // 
            this.btnAccountDel.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAccountDel.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnAccountDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccountDel.Location = new System.Drawing.Point(528, 121);
            this.btnAccountDel.Name = "btnAccountDel";
            this.btnAccountDel.Size = new System.Drawing.Size(150, 45);
            this.btnAccountDel.TabIndex = 9;
            this.btnAccountDel.Text = "Xóa";
            this.btnAccountDel.UseVisualStyleBackColor = false;
            this.btnAccountDel.Click += new System.EventHandler(this.btnAccountDel_Click);
            // 
            // rdbStaff
            // 
            this.rdbStaff.AutoSize = true;
            this.rdbStaff.BackColor = System.Drawing.Color.Transparent;
            this.rdbStaff.Enabled = false;
            this.rdbStaff.Location = new System.Drawing.Point(334, 168);
            this.rdbStaff.Name = "rdbStaff";
            this.rdbStaff.Size = new System.Drawing.Size(145, 37);
            this.rdbStaff.TabIndex = 11;
            this.rdbStaff.TabStop = true;
            this.rdbStaff.Text = "Nhân viên";
            this.rdbStaff.UseVisualStyleBackColor = false;
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.BackColor = System.Drawing.Color.Transparent;
            this.rdbManager.Enabled = false;
            this.rdbManager.Location = new System.Drawing.Point(187, 168);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(119, 37);
            this.rdbManager.TabIndex = 12;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Quản lý";
            this.rdbManager.UseVisualStyleBackColor = false;
            // 
            // fmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee.Properties.Resources.color7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 504);
            this.Controls.Add(this.rdbManager);
            this.Controls.Add(this.rdbStaff);
            this.Controls.Add(this.btnAccountDel);
            this.Controls.Add(this.btnAccountEdit);
            this.Controls.Add(this.btnAcountAdd);
            this.Controls.Add(this.txbDisplayname);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.dtgvAccount);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin các tài khoản";
            this.Load += new System.EventHandler(this.fmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbDisplayname;
        private System.Windows.Forms.Button btnAcountAdd;
        private System.Windows.Forms.Button btnAccountEdit;
        private System.Windows.Forms.Button btnAccountDel;
        private System.Windows.Forms.RadioButton rdbStaff;
        private System.Windows.Forms.RadioButton rdbManager;
    }
}