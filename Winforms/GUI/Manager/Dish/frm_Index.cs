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

namespace Winforms.GUI.Manager.Dish
{
    public partial class frm_Index : Form
    {
        API.Dishes dishes = new API.Dishes();

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
            dataGridView1.DataSource = dishes.index();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên món";
            dataGridView1.Columns[2].HeaderText = "Giá";
            dataGridView1.Columns[3].HeaderText = "Mô tả";
            dataGridView1.Columns[4].HeaderText = "Ngày tạo";
            dataGridView1.Columns[5].HeaderText = "Lần cập nhật cuối";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            double price = double.Parse(dataGridView1.CurrentRow.Cells["price"].Value.ToString());
            string description = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
            frm_View frm = new frm_View(id, name, price, description);
            frm.ShowDialog();
            LoadDL();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            frm_Create frm = new frm_Create();
            frm.ShowDialog();
            LoadDL();
        }
    }
}
