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
    public partial class FrmInventoryManager : Form
    {
        //gọi context là biến ching để đưa database vào
        ShopMoHinhDB context = new ShopMoHinhDB();
        public FrmInventoryManager()
        {
            InitializeComponent();
        }

        //Đưa tên các phân loại hàng hóa combobox
        private void FillClassCombobox(List<Class> ListClasses)
        {
            this.cmbClass.DataSource = ListClasses;
            this.cmbClass.DisplayMember = "Name";
            this.cmbClass.ValueMember = "ID";
        }


        //Đưa database vào Datagridview
        private void BindGrid(List<Item> ListItems)
        {
            DgvInventory.Rows.Clear();
            foreach (var item in ListItems)
            {
                int index = DgvInventory.Rows.Add();
                DgvInventory.Rows[index].Cells[0].Value = item.ID;
                DgvInventory.Rows[index].Cells[1].Value = item.Class.Name;
                DgvInventory.Rows[index].Cells[2].Value = item.ItemName;
                DgvInventory.Rows[index].Cells[3].Value = item.Price;
                DgvInventory.Rows[index].Cells[4].Value = item.Inventory;
            }
        }

        private void FrmInventoryManager_Load(object sender, EventArgs e)
        {
            try
            {

                List<Class> ListClasses = context.Classes.ToList();
                List<Item> ListItems = context.Items.ToList();
                FillClassCombobox(ListClasses);
                BindGrid(ListItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFullname.Text == "" || txtPrice.Text == "" || txtInventory.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !!");
                Item db = new Item();
                {
                    //Đưa thuộc tín của textbox vào database  
                    db.ID = txtID.Text.ToString();
                    db.ItemName = txtFullname.Text.ToString();
                    db.Price = int.Parse(txtPrice.Text);
                    db.Inventory = int.Parse(txtInventory.Text);
                    db.ClassID = this.cmbClass.SelectedIndex + 1;
                    this.cmbClass.SelectedIndex = (int)db.ClassID - 1;
                    //thêm và lưu lại sửa đổi vào database
                    context.Items.Add(db);
                    context.SaveChanges();
                    txtID.Text = "";txtFullname.Text = "";txtInventory.Text = "";txtPrice.Text = "";
                    //thực hiện lại event form_load để cập nhật datagridview những thông tin vừa được cập nhật vào database  
                    try
                    {

                        List<Class> ListClasses = context.Classes.ToList();
                        List<Item> ListItems = context.Items.ToList();
                        FillClassCombobox(ListClasses);
                        BindGrid(ListItems);
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

        //CellClick là event để mỗi lúc nhấn vào bất kì ô nào của mỗi hàng thì sẽ chọn cả hàng để thực hiện
        //Hàm dưới này là để mỗi lúc nhấn vào thuộc tính bất kì của mỗi item thì nó sẽ đưa thông tin của nhân viên ra lại đúng text để dễ chỉnh sửa hoặc xóa
        private void DgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = DgvInventory.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtFullname.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
            txtInventory.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFullname.Text == "" || txtPrice.Text == "" || txtInventory.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                Item dbUpdate = context.Items.FirstOrDefault(p => p.ID == txtID.Text);
                if (dbUpdate == null)
                    throw new Exception("Không tìm thấy sản phẩm cần sửa!!!");
                else
                {
                    dbUpdate.ID = txtID.Text.ToString();
                    dbUpdate.ItemName = txtFullname.Text.ToString();
                    dbUpdate.Price = int.Parse(txtPrice.Text);
                    dbUpdate.Inventory = int.Parse(txtInventory.Text);
                    dbUpdate.ClassID = this.cmbClass.SelectedIndex + 1;
                    this.cmbClass.SelectedIndex = (int)dbUpdate.ClassID - 1;
                    context.SaveChanges();
                    txtID.Text = ""; txtFullname.Text = ""; txtInventory.Text = ""; txtPrice.Text = "";
                    try
                    {

                        List<Class> ListClasses = context.Classes.ToList();
                        List<Item> ListItems = context.Items.ToList();
                        FillClassCombobox(ListClasses);
                        BindGrid(ListItems);
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
                if (txtID.Text == "" || txtFullname.Text == "" || txtPrice.Text == "" || txtInventory.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                Item dbDelete = context.Items.FirstOrDefault(p => p.ID == txtID.Text);
                if (dbDelete == null)
                    throw new Exception("Không tìm thấy sản phẩm cần xóa!!!");
                else
                {
                    context.Items.Remove(dbDelete);
                    context.SaveChanges();
                    txtID.Text = ""; txtFullname.Text = ""; txtInventory.Text = ""; txtPrice.Text = "";
                    try
                    {

                        List<Class> ListClasses = context.Classes.ToList();
                        List<Item> ListItems = context.Items.ToList();
                        FillClassCombobox(ListClasses);
                        BindGrid(ListItems);
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

        //Đã được nói ở code của form tableManager
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
