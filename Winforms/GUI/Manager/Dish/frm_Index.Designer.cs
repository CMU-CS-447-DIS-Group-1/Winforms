﻿
namespace Winforms.GUI.Manager.Dish
{
    partial class frm_Index
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ico_Create = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(620, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 30);
            this.textBox1.TabIndex = 1;
            // 
            // ico_Create
            // 
            this.ico_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ico_Create.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ico_Create.IconColor = System.Drawing.Color.Black;
            this.ico_Create.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ico_Create.IconSize = 20;
            this.ico_Create.Location = new System.Drawing.Point(12, 12);
            this.ico_Create.Name = "ico_Create";
            this.ico_Create.Size = new System.Drawing.Size(75, 38);
            this.ico_Create.TabIndex = 4;
            this.ico_Create.Text = "Tạo";
            this.ico_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ico_Create.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.IconSize = 24;
            this.btn_Search.Location = new System.Drawing.Point(749, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(38, 35);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // frm_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.ico_Create);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Index";
            this.Text = "Quản lí món ăn";
            this.Load += new System.EventHandler(this.frm_Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ico_Create;
        private FontAwesome.Sharp.IconButton btn_Search;
    }
}