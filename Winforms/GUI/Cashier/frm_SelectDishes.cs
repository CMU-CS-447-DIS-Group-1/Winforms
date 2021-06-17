using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.GUI.Cashier
{
    public partial class frm_SelectDishes : Form
    {
        API.Dishes dishes = new API.Dishes();
        int tableID;

        public frm_SelectDishes(int tableID)
        {
            InitializeComponent();
            this.tableID = tableID;
        }

        private void frm_SelectDishes_Load(object sender, EventArgs e)
        {
            LoadDL();
            lbl_TableID.Text += tableID;
        }

        private void LoadDL()
        {
            dataGridView1.DataSource = dishes.index();
            LoadColumns();
        }

        private void LoadColumns()
        {
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Tên món";
            dataGridView1.Columns["price"].HeaderText = "Giá";
            dataGridView1.Columns["description"].HeaderText = "Mô tả";
            dataGridView1.Columns.Remove("created_at");
            dataGridView1.Columns.Remove("updated_at");
        }

        private void CalTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView_Order.Rows)
            {
                total += double.Parse(row.Cells["cost"].Value.ToString());
            }
            lbl_Total.Text = total.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            double price = double.Parse(dataGridView1.CurrentRow.Cells["price"].Value.ToString());
            int quantity = 1;
            double cost = price * quantity;
            // Find existed dish
            String searchValue = id.ToString();
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView_Order.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            // end
            if (rowIndex == -1)
            {
                dataGridView_Order.Rows.Add(id, name, price, quantity, cost);
            } else
            {
                var row = dataGridView_Order.Rows[rowIndex];
                int newQuantity = int.Parse(row.Cells["quantity"].Value.ToString()) + 1;
                double newCost = double.Parse(row.Cells["price"].Value.ToString()) * newQuantity;
                dataGridView_Order.Rows[rowIndex].Cells["quantity"].Value = newQuantity;
                dataGridView_Order.Rows[rowIndex].Cells["cost"].Value = newCost;
            }
            CalTotal();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var row = dataGridView_Order.CurrentRow;
            int newQuantity = int.Parse(row.Cells["quantity"].Value.ToString()) + 1;
            double newCost = double.Parse(row.Cells["price"].Value.ToString()) * newQuantity;
            row.Cells["quantity"].Value = newQuantity;
            row.Cells["cost"].Value = newCost;
            CalTotal();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            var row = dataGridView_Order.CurrentRow;
            int newQuantity = int.Parse(row.Cells["quantity"].Value.ToString()) - 1;
            double newCost = double.Parse(row.Cells["price"].Value.ToString()) * newQuantity;
            row.Cells["quantity"].Value = newQuantity;
            row.Cells["cost"].Value = newCost;
            CalTotal();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dynamic result = dishes.show(txt_Keyword.Text);
            if (result != null && result.code == 1)
            {
                dataGridView1.DataSource = result.data;
                LoadColumns();
            } else
            {
                MessageBox.Show("Không tìm thấy món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            API.Table table = new API.Table();
            foreach (DataGridViewRow row in dataGridView_Order.Rows)
            {
                int dishID = int.Parse(row.Cells["id"].Value.ToString());
                int quantity = int.Parse(row.Cells["quantity"].Value.ToString());
                double price = int.Parse(row.Cells["price"].Value.ToString());
                table.order(tableID, dishID, quantity, price);
            }
            MessageBox.Show("Đặt món thành công!", "Thông báo");
            dataGridView_Order.Rows.Clear();
            CalTotal();
        }
    }
}
