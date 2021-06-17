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
    public partial class frm_ViewInvoice : Form
    {
        API.Invoice invoice = new API.Invoice();
        int tableID;

        public frm_ViewInvoice(int tableID)
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
            dataGridView_Order.DataSource = invoice.view(this.tableID.ToString());
            LoadColumns();
            CalTotal();
        }

        private void LoadColumns()
        {
            dataGridView_Order.Columns["name"].HeaderText = "Tên món";
            dataGridView_Order.Columns["price"].HeaderText = "Giá";
            dataGridView_Order.Columns["quantity"].HeaderText = "Số lượng";
            dataGridView_Order.Columns["cost"].HeaderText = "Thành tiền";
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn in hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                dynamic result = invoice.print(this.tableID.ToString());
                if (result != null && result.status == 1)
                {
                    MessageBox.Show("In thành công!", "Thông báo");
                    this.Close();
                }
            }

        }
    }
}
