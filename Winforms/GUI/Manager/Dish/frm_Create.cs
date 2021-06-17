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
    public partial class frm_Create : Form
    {
        public frm_Create()
        {
            InitializeComponent();
            txt_ID.Text = "Tự động tạo";
            txt_Price.Maximum = Decimal.MaxValue;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thêm món ăn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                var dishes = new API.Dishes();
                dynamic result = dishes.store(txt_Name.Text, double.Parse(txt_Price.Text), txt_Description.Text);
                if (result != null && result.code == 1)
                {
                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại!", "Thông báo");
                }
            }
        }
    }
}
