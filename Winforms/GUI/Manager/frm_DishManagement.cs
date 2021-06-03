using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.GUI.Manager
{
    public partial class frm_DishManagement : Form
    {
        API.Dishes dishes = new API.Dishes();

        public frm_DishManagement()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_DishManagement_Load(object sender, EventArgs e)
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
            dataGridView1.Columns.Add("actions", "Hành động");
            DataGridViewButtonColumn actions = new DataGridViewButtonColumn();
            actions.Name = "actions_column";
            actions.HeaderText = "Hành động";
            actions.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(actions);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txt_Name.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            txt_Price.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            txt_Description.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
        }

        private bool isDouble(string number)
        {
            double num;
            bool result = double.TryParse(number, out num);
            return result;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Dish.frm_Create frm = new Dish.frm_Create();
            frm.ShowDialog();
            /*
            if (txt_Name.Text != null && (txt_Price.Text != null && isDouble(txt_Price.Text)))
            {
                MessageBox.Show(isDouble(txt_Price.Text).ToString());
                dynamic result = dishes.store(txt_Name.Text, double.Parse(txt_Price.Text), txt_Description.Text);
                if (result != null && result.code == 1)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadDL();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các thông tin!");
            }
            */
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            dynamic result = dishes.update(int.Parse(txt_ID.Text), txt_Name.Text, double.Parse(txt_Price.Text), txt_Description.Text);
            if (result != null && result.code == 1)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                LoadDL();
            } else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dynamic result = dishes.destroy(int.Parse(txt_ID.Text));
            if (result == true)
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                LoadDL();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại!");
            }
        }
    }
}
