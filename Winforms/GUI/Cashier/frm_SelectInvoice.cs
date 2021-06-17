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

namespace Winforms.GUI.Cashier
{
    public partial class frm_SelectInvoice : Form
    {
        API.Table table = new API.Table();

        public frm_SelectInvoice()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_SelectTable_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void LoadDL()
        {
            imageList_Table.Images.Clear();
            listView1.Items.Clear();
            dynamic tables = table.index();
            int i = 1;
            foreach (var item in tables.data)
            {
                if (item.status == 1)
                {
                    imageList_Table.Images.Add(Properties.Resources.table_1);
                    listView1.Items.Add("Bàn số: " + i, 0);
                }
                i++;
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string text = listView1.SelectedItems[0].Text;
            string[] str = text.Split(':');
            int tableID = int.Parse(str[1].Trim(' '));
            frm_ViewInvoice frm = new frm_ViewInvoice(tableID);
            frm.ShowDialog();
            LoadDL();
        }
    }
}
