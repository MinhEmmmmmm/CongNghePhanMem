using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLshopmohinh
{
    public partial class FrmBIllManager : Form
    {
        ShopMoHinhDB context =  new ShopMoHinhDB();
        public FrmBIllManager()
        {
            InitializeComponent();
            List<Bill> ListBills = context.Bills.ToList();
            BindGrid(ListBills);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BindGrid(List<Bill> ListBills)
        {
            DgvBill.Rows.Clear();
            foreach (var item in ListBills)
            {
                int index = DgvBill.Rows.Add();
                DgvBill.Rows[index].Cells[0].Value = item.ID;
                DgvBill.Rows[index].Cells[1].Value = item.Date;
                DgvBill.Rows[index].Cells[2].Value = item.Client.FullName;
                DgvBill.Rows[index].Cells[3].Value = item.TaltolMoney;
            }
        }
    }
}
