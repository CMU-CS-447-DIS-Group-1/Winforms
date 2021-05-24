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
        Object.User user = new Object.User();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == null || txt_Password.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo");
            }
            else {
                if (auth.login(txt_Email.Text, txt_Password.Text))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    this.Hide();
                    // 0 = manager, 1 = cashier
                    if (user.info("level") == 0)
                    {
                        Manager.frm_Main frm = new Manager.frm_Main();
                        frm.ShowDialog();
                    }
                    else if (user.info("level") == 1)
                    {
                        Cashier.frm_Main frm = new Cashier.frm_Main();
                        frm.ShowDialog();
                    }
                    this.Show();
                    if (auth.logout())
                    {
                        MessageBox.Show("Đăng xuất thành công!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
                }
            }
        }
    }
}
