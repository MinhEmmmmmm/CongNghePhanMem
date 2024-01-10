using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLshopmohinh
{
     
    public partial class FrmLogin : Form
    {
        public ShopMoHinhDB context = new ShopMoHinhDB();
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chkbxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
                txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUseName.Text == "" || txtPassword.Text == "")
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {                
                Staff dbLogin = context.Staffs.FirstOrDefault(p => p.UserName == txtUseName.Text);
                if (dbLogin == null)
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                else
                {
                    FrmTableManager f = new FrmTableManager(dbLogin);
                    this.Hide();
                    f.ShowDialog();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
