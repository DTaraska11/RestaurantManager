﻿namespace RestaurantManager
{
    partial class OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ORDERFORM = new System.Windows.Forms.TextBox();
            this.dgvMenuItem = new System.Windows.Forms.DataGridView();
            this.appDataSet1 = new RestaurantManager.AppDataSet();
            this.appDataSet2 = new RestaurantManager.AppDataSet();
            this.ADD = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuItemName = new System.Windows.Forms.TextBox();
            this.MenuItemCost = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNCLEAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDERFORM
            // 
            this.ORDERFORM.BackColor = System.Drawing.Color.White;
            this.ORDERFORM.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDERFORM.Location = new System.Drawing.Point(18, 16);
            this.ORDERFORM.Name = "ORDERFORM";
            this.ORDERFORM.Size = new System.Drawing.Size(584, 41);
            this.ORDERFORM.TabIndex = 0;
            this.ORDERFORM.Text = "ORDER DETAILS";
            // 
            // dgvMenuItem
            // 
            this.dgvMenuItem.AllowUserToAddRows = false;
            this.dgvMenuItem.AllowUserToDeleteRows = false;
            this.dgvMenuItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMenuItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItem.Location = new System.Drawing.Point(0, 140);
            this.dgvMenuItem.Name = "dgvMenuItem";
            this.dgvMenuItem.RowHeadersWidth = 82;
            this.dgvMenuItem.RowTemplate.Height = 33;
            this.dgvMenuItem.Size = new System.Drawing.Size(692, 231);
            this.dgvMenuItem.TabIndex = 2;
            this.dgvMenuItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvMenuItem.DoubleClick += new System.EventHandler(this.dgvMenuItem_DoubleClick);
            // 
            // appDataSet1
            // 
            this.appDataSet1.DataSetName = "AppDataSet";
            this.appDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDataSet2
            // 
            this.appDataSet2.DataSetName = "AppDataSet";
            this.appDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ADD.ForeColor = System.Drawing.Color.Fuchsia;
            this.ADD.Location = new System.Drawing.Point(717, 185);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(108, 56);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DELETE.ForeColor = System.Drawing.Color.Fuchsia;
            this.DELETE.Location = new System.Drawing.Point(717, 257);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(146, 56);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "COST";
            // 
            // MenuItemName
            // 
            this.MenuItemName.Location = new System.Drawing.Point(756, 26);
            this.MenuItemName.Name = "MenuItemName";
            this.MenuItemName.Size = new System.Drawing.Size(218, 31);
            this.MenuItemName.TabIndex = 9;
            // 
            // MenuItemCost
            // 
            this.MenuItemCost.Location = new System.Drawing.Point(755, 91);
            this.MenuItemCost.Name = "MenuItemCost";
            this.MenuItemCost.Size = new System.Drawing.Size(219, 31);
            this.MenuItemCost.TabIndex = 10;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(161, 85);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(441, 31);
            this.Search.TabIndex = 11;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "SEARCH";
            // 
            // BTNCLEAR
            // 
            this.BTNCLEAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNCLEAR.ForeColor = System.Drawing.Color.Fuchsia;
            this.BTNCLEAR.Location = new System.Drawing.Point(841, 185);
            this.BTNCLEAR.Name = "BTNCLEAR";
            this.BTNCLEAR.Size = new System.Drawing.Size(111, 56);
            this.BTNCLEAR.TabIndex = 13;
            this.BTNCLEAR.Text = "CLEAR";
            this.BTNCLEAR.UseVisualStyleBackColor = false;
            this.BTNCLEAR.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.BTNCLEAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.MenuItemCost);
            this.Controls.Add(this.MenuItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dgvMenuItem);
            this.Controls.Add(this.ORDERFORM);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(977, 387);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ORDERFORM;
        private System.Windows.Forms.DataGridView dgvMenuItem;
        private AppDataSet appDataSet1;
        private AppDataSet appDataSet2;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MenuItemName;
        private System.Windows.Forms.TextBox MenuItemCost;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNCLEAR;
    }
}
