
namespace Winforms.GUI.Cashier
{
    partial class frm_ViewInvoice
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
            this.imageList_Dishes = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_TableID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Print = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_Dishes
            // 
            this.imageList_Dishes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Dishes.ImageSize = new System.Drawing.Size(40, 40);
            this.imageList_Dishes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.AllowUserToAddRows = false;
            this.dataGridView_Order.AllowUserToDeleteRows = false;
            this.dataGridView_Order.AllowUserToOrderColumns = true;
            this.dataGridView_Order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Order.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Location = new System.Drawing.Point(12, 51);
            this.dataGridView_Order.MultiSelect = false;
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.ReadOnly = true;
            this.dataGridView_Order.RowHeadersVisible = false;
            this.dataGridView_Order.RowHeadersWidth = 51;
            this.dataGridView_Order.RowTemplate.Height = 24;
            this.dataGridView_Order.Size = new System.Drawing.Size(866, 301);
            this.dataGridView_Order.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền: ";
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(610, 365);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(268, 27);
            this.lbl_Total.TabIndex = 2;
            this.lbl_Total.Text = "0";
            // 
            // lbl_TableID
            // 
            this.lbl_TableID.AutoSize = true;
            this.lbl_TableID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableID.Location = new System.Drawing.Point(123, 9);
            this.lbl_TableID.Name = "lbl_TableID";
            this.lbl_TableID.Size = new System.Drawing.Size(92, 25);
            this.lbl_TableID.TabIndex = 6;
            this.lbl_TableID.Text = "Bàn số: ";
            // 
            // btn_Print
            // 
            this.btn_Print.AutoSize = true;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_Print.IconColor = System.Drawing.Color.Black;
            this.btn_Print.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Print.IconSize = 24;
            this.btn_Print.Location = new System.Drawing.Point(486, 403);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(392, 35);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "In hóa đơn";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // frm_ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Winforms.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.lbl_TableID);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Order);
            this.Name = "frm_ViewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frm_SelectDishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList_Dishes;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_TableID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btn_Print;
    }
}