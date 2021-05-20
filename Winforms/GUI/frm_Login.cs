using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.GUI
{
    public partial class frm_Login : Form
    {
        API.Auth auth = new API.Auth();
        API.Dishes dishes = new API.Dishes();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (auth.login(txt_Email.Text, txt_Password.Text))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
            } else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dishes.index().data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (auth.logout())
            {
                MessageBox.Show("Đăng xuất thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng xuất thất bại!", "Thông báo");
            }
        }
    }
}
