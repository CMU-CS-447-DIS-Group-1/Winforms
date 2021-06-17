using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.GUI.Manager.Invoice
{
    public partial class frm_View : Form
    {
        API.Invoice invoice = new API.Invoice();
        string user_name;
        int table_id;
        string created_at;
        string updated_at;

        public frm_View(string user_name, int table_id, string created_at, string updated_at)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.table_id = table_id;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        private void frm_View_Load(object sender, EventArgs e)
        {
            txt_Soban.Text = table_id.ToString();
            txt_Thungan.Text = user_name;
            txt_ngaytao.Text = created_at;
            txt_capnhatlast.Text = updated_at;
            LoadDL();
        }

        private void LoadDL()
        {
            dataGridView1.DataSource = invoice.show(table_id.ToString());
            LoadColumns();
        }

        private void LoadColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Tên món";
            dataGridView1.Columns[1].HeaderText = "Giá";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Thành tiền";
        }
    }
}
