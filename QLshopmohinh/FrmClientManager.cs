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
    public partial class FrmClientManager : Form
    {
        public FrmClientManager()
        {
            InitializeComponent();
        }
        ShopMoHinhDB context = new ShopMoHinhDB();
        private void FrmClientManager_Load(object sender, EventArgs e)
        {

            List<Client> ListClients = context.Clients.ToList();
            List<ClientRank> ListClientRank = context.ClientRanks.ToList();
            FillGrid(ListClients);


        }
        public void FillGrid(List<Client> ListClients)
        {
            DgvClient.Rows.Clear();
            foreach (var client in ListClients)
            {
                int index = DgvClient.Rows.Add();
                DgvClient.Rows[index].Cells[0].Value = client.ID;
                DgvClient.Rows[index].Cells[1].Value = client.FullName;
                DgvClient.Rows[index].Cells[2].Value = client.Address;
                DgvClient.Rows[index].Cells[3].Value = client.ToltalMoney;
                DgvClient.Rows[index].Cells[4].Value = client.ClientRank.Rank;
                DgvClient.Rows[index].Cells[5].Value = client.PhoneNumber;


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFullName.Text == "" || txtAddress.Text == "" || txtToltalMoney.Text == "" || txtPhoneNumber.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !!");
                Client db = new Client();
                {
                    db.ID = txtID.Text.ToString();
                    db.FullName = txtFullName.Text.ToString();
                    db.Address = txtAddress.Text.ToString();
                    int Money = int.Parse(txtToltalMoney.Text);
                    db.ToltalMoney = Money;
                    if (Money > 3500000)
                    {
                        if (Money > 8000000)
                        {
                            if (Money >= 15000000)
                            {
                                db.RankID = 4;
                            }
                            db.RankID = 3;
                        }
                        db.RankID = 2;
                    }
                    else
                        db.RankID = 1;
                    db.PhoneNumber = txtPhoneNumber.Text.ToString();
                    context.Clients.Add(db);
                    context.SaveChanges();
                    txtID.Text = ""; txtFullName.Text = ""; txtAddress.Text = ""; txtToltalMoney.Text = ""; txtPhoneNumber.Text = "";
                    try
                    {

                        List<Client> ListClient = context.Clients.ToList();
                        FillGrid(ListClient);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    throw new Exception("Thêm dữ liệu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = DgvClient.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
                txtID.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null)
                txtFullName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
                txtAddress.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value != null)
                txtToltalMoney.Text = row.Cells[3].Value.ToString();
            if (row.Cells[5].Value != null)
                txtPhoneNumber.Text = row.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFullName.Text == "" || txtAddress.Text == "" || txtToltalMoney.Text == "" || txtPhoneNumber.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                Client dbUpdate = context.Clients.FirstOrDefault(p => p.ID == txtID.Text);
                if (dbUpdate == null)
                    throw new Exception("Không tìm thấy sản phẩm cần sửa!!!");
                else
                {
                    dbUpdate.ID = txtID.Text.ToString();
                    dbUpdate.FullName = txtFullName.Text.ToString();
                    dbUpdate.Address = txtAddress.Text.ToString();
                    int Money = int.Parse(txtToltalMoney.Text);
                    dbUpdate.ToltalMoney = Money;
                    if (Money > 3500000)
                    {
                        if (Money > 8000000)
                        {
                            if (Money >= 15000000)
                            {
                                dbUpdate.RankID = 4;
                            }
                            dbUpdate.RankID = 3;
                        }
                        dbUpdate.RankID = 2;
                    }
                    else
                        dbUpdate.RankID = 1;
                    dbUpdate.PhoneNumber = txtPhoneNumber.Text.ToString();
                    context.SaveChanges();
                    txtID.Text = ""; txtFullName.Text = ""; txtAddress.Text = ""; txtToltalMoney.Text = ""; txtPhoneNumber.Text = "";
                    try
                    {

                        List<Client> ListClients = context.Clients.ToList();

                        FillGrid(ListClients);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    throw new Exception("Cập nhật dữ liệu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFullName.Text == "" || txtAddress.Text == "" || txtToltalMoney.Text == "" || txtPhoneNumber.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                Client dbDelete = context.Clients.FirstOrDefault(p => p.ID == txtID.Text);
                if (dbDelete == null)
                    throw new Exception("Không tìm thấy sản phẩm cần xóa!!!");
                else
                {
                    context.Clients.Remove(dbDelete);
                    context.SaveChanges();
                    txtID.Text = ""; txtFullName.Text = ""; txtAddress.Text = ""; txtToltalMoney.Text = ""; txtPhoneNumber.Text = "";
                    try
                    {

                        List<Client> ListClient = context.Clients.ToList();
                        FillGrid(ListClient);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    throw new Exception("Xóa dữ liệu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FrmClientManager_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
