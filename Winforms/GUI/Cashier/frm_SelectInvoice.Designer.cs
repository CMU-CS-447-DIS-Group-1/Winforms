
namespace Winforms.GUI.Cashier
{
    partial class frm_SelectInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SelectInvoice));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Bàn đã có người ngồi", "(none)");
            this.imageList_Table = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.imageList_ChuThich = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reload = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // imageList_Table
            // 
            this.imageList_Table.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Table.ImageStream")));
            this.imageList_Table.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Table.Images.SetKeyName(0, "table_1.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList_Table;
            this.listView1.Location = new System.Drawing.Point(199, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 385);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView2.LargeImageList = this.imageList_ChuThich;
            this.listView2.Location = new System.Drawing.Point(13, 81);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(180, 357);
            this.listView2.StateImageList = this.imageList_ChuThich;
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // imageList_ChuThich
            // 
            this.imageList_ChuThich.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_ChuThich.ImageStream")));
            this.imageList_ChuThich.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_ChuThich.Images.SetKeyName(0, "table_1.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chú thích";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reload.AutoSize = true;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_Reload.IconColor = System.Drawing.Color.Black;
            this.btn_Reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Reload.IconSize = 20;
            this.btn_Reload.Location = new System.Drawing.Point(666, 12);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(122, 35);
            this.btn_Reload.TabIndex = 1;
            this.btn_Reload.Text = "Cập nhật";
            this.btn_Reload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // frm_SelectInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.listView1);
            this.Name = "frm_SelectInvoice";
            this.Text = "Chọn bàn để xem hóa đơn";
            this.Load += new System.EventHandler(this.frm_SelectTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList_Table;
        private System.Windows.Forms.ListView listView1;
        private FontAwesome.Sharp.IconButton btn_Reload;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList imageList_ChuThich;
        private System.Windows.Forms.Label label1;
    }
}