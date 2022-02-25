using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            if (Login(userName, passWord))
            {
                fmMain f = new fmMain(userName, AccountDAO.Instance.GetTypeAccount(userName));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
                txbUsername.Text = "";
                txbPassword.Text = "";
                txbUsername.Focus();
            }
            
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void fmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txbUsername.ForeColor = Color.FromArgb(78, 184, 206);


            panel3.BackColor = Color.WhiteSmoke;
            txbPassword.ForeColor = Color.WhiteSmoke;

        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Clear();
            txbPassword.PasswordChar = '*';
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            txbPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.WhiteSmoke;
            txbUsername.ForeColor = Color.WhiteSmoke;


        }
        int x = 9, y = 12, a = 1;

        private void btnSighup_Click(object sender, EventArgs e)
        {
            fmSighup f = new fmSighup();
            f.ShowDialog();
            this.Show();
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if(x>=773)
                {
                    a = -1;
                    label1.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0,255));

                }   
                if(x<=9)
                {
                    a = 1;
                    label1.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

                }

            }
            catch(Exception )
            { }
        }
    }
}
