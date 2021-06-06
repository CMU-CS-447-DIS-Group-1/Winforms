using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.GUI.Manager.Dish
{
    public partial class frm_View : Form
    {
        int id;
        string name;
        double price;
        string description;

        public frm_View(int id, string name, double price, string description)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.Text += name;
        }

        private void frm_View_Load(object sender, EventArgs e)
        {
            txt_Price.Maximum = Decimal.MaxValue;
            lbl_ID.Text += id;
            txt_Name.Text = name;
            txt_Price.Text = price.ToString();
            txt_Description.Text = description;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn xóa món ăn \"" + name + "\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                var dishes = new API.Dishes();
                bool result = dishes.destroy(id);
                if (result == true)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn cập nhật thông tin món ăn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                var dishes = new API.Dishes();
                dynamic result = dishes.update(id, txt_Name.Text, double.Parse(txt_Price.Text), txt_Description.Text);
                if (result != null && result.code == 1)
                {
                    MessageBox.Show("Cập nhật thông tin món ăn thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin món ăn thất bại!");
                }
            }
        }
    }
}
