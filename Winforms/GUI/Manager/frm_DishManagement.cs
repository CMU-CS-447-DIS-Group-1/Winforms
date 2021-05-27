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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txt_Name.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            txt_Price.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            txt_Description.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            dynamic result = dishes.store(txt_Name.Text, double.Parse(txt_Price.Text), txt_Description.Text);
            if (result != null && result.code == 1)
            {
                MessageBox.Show("Added!");
                LoadDL();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            dynamic result = dishes.update(int.Parse(txt_ID.Text), txt_Name.Text, double.Parse(txt_Price.Text), txt_Description.Text);
            if (result != null && result.code == 1)
            {
                MessageBox.Show("Updated!");
                LoadDL();
            } else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dynamic result = dishes.destroy(int.Parse(txt_ID.Text));
            if (result == true)
            {
                MessageBox.Show("Deleted!");
                LoadDL();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }
    }
}
