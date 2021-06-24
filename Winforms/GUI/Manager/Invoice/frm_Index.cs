using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Winforms.GUI.Manager.Invoice
{
    public partial class frm_Index : Form
    {
        API.Invoice invoices = new API.Invoice();

        public frm_Index()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_Index_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void LoadDL()
        {
            dataGridView1.DataSource = invoices.index();
            if (dataGridView1.Rows.Count > 0)
            {
                handle();
                LoadCols();
            }
        }

        private void handle()
        {
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string status = row.Cells["status"].Value.ToString();
                if (status == "0") row.Cells["status"].Value = "Chưa thanh toán";
                else row.Cells["status"].Value = "Đã thanh toán";
            }
            
        }

        private void LoadCols()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Số bàn";
            dataGridView1.Columns[3].HeaderText = "Trạng thái";
            dataGridView1.Columns[4].HeaderText = "Ngày tạo";
            dataGridView1.Columns[5].HeaderText = "Lần cập nhật cuối";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string user_name = dataGridView1.CurrentRow.Cells["user_name"].Value.ToString();
            int table_id = int.Parse(dataGridView1.CurrentRow.Cells["table_id"].Value.ToString());
            string created_at = dataGridView1.CurrentRow.Cells["created_at"].Value.ToString();
            string updated_at = dataGridView1.CurrentRow.Cells["updated_at"].Value.ToString();
            frm_View frm = new frm_View(user_name, table_id, created_at, updated_at);
            frm.ShowDialog();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDL();
        }
    }
}
