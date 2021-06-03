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

namespace Winforms.GUI.Manager
{
    public partial class frm_Main : Form
    {
        Object.User user = new Object.User();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(1);
            } else
            {
                e.Cancel = true;
            }
        }

        private void dishManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frm_DishManagement"] == null)
            {
                frm_DishManagement frm = new frm_DishManagement();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_DishManagement"].Activate();
            
            /**
            if (Application.OpenForms["Dish.frm_Index"] == null)
            {
                Dish.frm_Index frm = new Dish.frm_Index();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_frm_Index"].Activate();
            */
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage = Winforms.Properties.Resources.background;
            Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImageLayout = ImageLayout.Stretch;
            toolStripStatusLabel_userName.Text += user.info("name");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
