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
    public partial class FrmStaffsManager : Form
    {
        public FrmStaffsManager()
        {
            InitializeComponent();
            List<Staff> ListStaff = context.Staffs.ToList();
            FillGrid(ListStaff);
        }
        ShopMoHinhDB context = new ShopMoHinhDB();

        private void FrmStaffsManager_Load(object sender, EventArgs e)
        {
        }
        private void FillGrid(List<Staff> ListStaff)
        {
            DgvStaff.Rows.Clear();
            foreach (var staff in ListStaff)
            {
                int index = DgvStaff.Rows.Add();
                DgvStaff.Rows[index].Cells[0].Value = staff.ID;
                DgvStaff.Rows[index].Cells[1].Value = staff.UserName;
                DgvStaff.Rows[index].Cells[2].Value = staff.FullName;
                DgvStaff.Rows[index].Cells[3].Value = staff.Password;
                if (staff.Type == 1)
                    DgvStaff.Rows[index].Cells[4].Value = "Quản lý";
                if (staff.Type == 0)
                    DgvStaff.Rows[index].Cells[4].Value = "Nhân viên";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtUseName.Text == "" || txtFullName.Text == "" || txtPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !!");
                Staff db = new Staff();
                {
                    db.ID = txtID.Text.ToString();
                    db.UserName = txtUseName.Text.ToString();
                    db.FullName = txtFullName.Text.ToString();
                    db.Password = txtPassword.Text.ToString();
                    if(cmbType.Text == "Nhân viên")
                        db.Type = 0;
                    if (cmbType.Text == "Quản Lý")
                        db.Type = 1;
                    context.Staffs.Add(db);
                    context.SaveChanges();
                    txtID.Text = ""; txtUseName.Text = ""; txtFullName.Text = ""; txtPassword.Text = "";
                    try
                    {

                        List<Staff> ListClient = context.Staffs.ToList();
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

        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = DgvStaff.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
                txtID.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null)
                txtUseName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
                txtFullName.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value != null)
                txtPassword.Text = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtID.Text == "" || txtUseName.Text == "" || txtFullName.Text == "" || txtPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                Staff dbUpdate = context.Staffs.FirstOrDefault(p => p.ID == txtID.Text);
                if (dbUpdate == null)
                    throw new Exception("Không tìm thấy sản phẩm cần sửa!!!");
                else
                {
                    dbUpdate.ID = txtID.Text.ToString();
                    dbUpdate.UserName = txtUseName.Text.ToString();
                    dbUpdate.FullName = txtFullName.Text.ToString();
                    dbUpdate.Password = txtPassword.Text.ToString();
                    if (cmbType.Text == "Nhân viên")
                        dbUpdate.Type = 0;
                    if (cmbType.Text == "Quản Lý")
                        dbUpdate.Type = 1;
                    context.SaveChanges();
                    txtID.Text = ""; txtFullName.Text = ""; txtUseName.Text = ""; txtPassword.Text = "";
                    try
                    {

                        List<Staff> ListStaff = context.Staffs.ToList();

                        FillGrid(ListStaff);
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
                if (txtID.Text == "" || txtUseName.Text == "" || txtPassword.Text == "" || txtFullName.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                Staff dbDelete = context.Staffs.FirstOrDefault(p => p.ID == txtID.Text);
                if (dbDelete == null)
                    throw new Exception("Không tìm thấy sản phẩm cần xóa!!!");
                else
                {
                    context.Staffs.Remove(dbDelete);
                    context.SaveChanges();
                    txtID.Text = ""; txtUseName.Text = ""; txtPassword.Text = ""; txtFullName.Text = "" ;
                    try
                    {

                        List<Staff> ListStaff = context.Staffs.ToList();
                        FillGrid(ListStaff);
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

        private void FrmStaffsManager_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
