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
    public partial class FrmAddClient : Form
    {
        ShopMoHinhDB context = new ShopMoHinhDB();
        public FrmAddClient()
        {
            InitializeComponent();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFullName.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !!");
                Client db = new Client();
                {
                    db.ID = txtID.Text.ToString();
                    db.FullName = txtFullName.Text.ToString();
                    db.Address = txtAddress.Text.ToString();
                    db.PhoneNumber = txtPhoneNumber.Text.ToString();
                    db.ToltalMoney = 0;
                    db.RankID = 1;
                    
                    context.Clients.Add(db);
                    context.SaveChanges();
                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
