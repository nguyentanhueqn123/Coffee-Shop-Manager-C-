using System;
using DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Coffee
{
    public partial class fmSighup : Form
    {
        public fmSighup()
        {
            InitializeComponent();
        }

        private void fmSighup_Load(object sender, EventArgs e)
        {
            AddBinding();
        }

        void AddBinding()
        {
            txbUsername.DataBindings.Clear();
            txbDisplayname.DataBindings.Clear();

            txbUsername.DataBindings.Add(new Binding("Text", AccountDAO.Instance.GetListAccount(), "Tài khoản", true, DataSourceUpdateMode.Never));
            txbDisplayname.DataBindings.Add(new Binding("Text", AccountDAO.Instance.GetListAccount(), "Tên hiển thị", true, DataSourceUpdateMode.Never));

            txbPassword.Text = "*";
        }

        public bool CheckAccount(string Account) //Check mk, tentk
        {
            return Regex.IsMatch(Account, "^[a-zA-z0-9]{4,24}$");
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {          
            string userName = txbUsername.Text;
            string displayName = txbDisplayname.Text;
            string passWord = txbPassword.Text;
            string repassWord = txbRePassword.Text;
            if (!CheckAccount(userName))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 4-24 kí tự, với các kí tự a-z, A-Z, 0-9!");
                return;
            }
            if (!CheckAccount(passWord))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 4-24 kí tự, với các kí tự a-z, A-Z, 0-9!");
                return;
            }
            if (passWord != repassWord)
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác! Vui lòng nhập lại!");
                return;
            }

            if (txbUsername.Enabled == false && txbPassword.Enabled == false && txbDisplayname.Enabled == false)
            {
                EnableComponent();
            }
            else
            {
                DisableComponent();
                try
                {
                    int Type = 0;
                    string query = "INSERT INTO Account VALUES ( N'" + userName + "' , N'" + displayName + "' , N'" + passWord + "' , N'" + Type + "')";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công !!!");
                }
                catch (Exception) { MessageBox.Show("Tài khoản này đã được đăng kí !!!"); }
            }

            void DisableComponent()
            {
                txbUsername.Enabled = false;
                txbPassword.Enabled = false;
                txbDisplayname.Enabled = false;       
                rdbStaff.Enabled = false;
            }

            void EnableComponent()
            {
                txbUsername.Enabled = true;
                txbPassword.Enabled = true;
                txbDisplayname.Enabled = true;
                rdbStaff.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
