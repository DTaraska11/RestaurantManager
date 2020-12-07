namespace RestaurantManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
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
            this.BTNCLEAR = new System.Windows.Forms.Button();
            this.REFRESH = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new RestaurantManager.AppDataSetTableAdapters.TableAdapterManager();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.STARTOVER = new System.Windows.Forms.Button();
            this.FINISHORDER = new System.Windows.Forms.Button();
            this.dgvFinishOrder = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalVal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDERFORM
            // 
            this.ORDERFORM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ORDERFORM.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDERFORM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ORDERFORM.Location = new System.Drawing.Point(22, 36);
            this.ORDERFORM.Name = "ORDERFORM";
            this.ORDERFORM.Size = new System.Drawing.Size(330, 67);
            this.ORDERFORM.TabIndex = 0;
            this.ORDERFORM.Text = "ORDER DETAILS";
            // 
            // dgvMenuItem
            // 
            this.dgvMenuItem.AllowUserToAddRows = false;
            this.dgvMenuItem.AllowUserToDeleteRows = false;
            this.dgvMenuItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMenuItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItem.Location = new System.Drawing.Point(19, 109);
            this.dgvMenuItem.Name = "dgvMenuItem";
            this.dgvMenuItem.ReadOnly = true;
            this.dgvMenuItem.RowHeadersWidth = 82;
            this.dgvMenuItem.RowTemplate.Height = 33;
            this.dgvMenuItem.Size = new System.Drawing.Size(692, 292);
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
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ADD.ForeColor = System.Drawing.Color.Fuchsia;
            this.ADD.Location = new System.Drawing.Point(751, 323);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(118, 56);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DELETE.ForeColor = System.Drawing.Color.Fuchsia;
            this.DELETE.Location = new System.Drawing.Point(1052, 323);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(131, 56);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(799, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "COST";
            // 
            // MenuItemName
            // 
            this.MenuItemName.Location = new System.Drawing.Point(908, 136);
            this.MenuItemName.Name = "MenuItemName";
            this.MenuItemName.Size = new System.Drawing.Size(273, 31);
            this.MenuItemName.TabIndex = 9;
            this.MenuItemName.TextChanged += new System.EventHandler(this.MenuItemName_TextChanged);
            // 
            // MenuItemCost
            // 
            this.MenuItemCost.Location = new System.Drawing.Point(908, 191);
            this.MenuItemCost.Name = "MenuItemCost";
            this.MenuItemCost.Size = new System.Drawing.Size(273, 31);
            this.MenuItemCost.TabIndex = 10;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(189, 398);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(519, 31);
            this.Search.TabIndex = 11;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // BTNCLEAR
            // 
            this.BTNCLEAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNCLEAR.ForeColor = System.Drawing.Color.Fuchsia;
            this.BTNCLEAR.Location = new System.Drawing.Point(908, 323);
            this.BTNCLEAR.Name = "BTNCLEAR";
            this.BTNCLEAR.Size = new System.Drawing.Size(111, 56);
            this.BTNCLEAR.TabIndex = 13;
            this.BTNCLEAR.Text = "CLEAR";
            this.BTNCLEAR.UseVisualStyleBackColor = false;
            this.BTNCLEAR.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // REFRESH
            // 
            this.REFRESH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.REFRESH.ForeColor = System.Drawing.Color.Fuchsia;
            this.REFRESH.Location = new System.Drawing.Point(18, 109);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(178, 42);
            this.REFRESH.TabIndex = 14;
            this.REFRESH.Text = "REFRESH";
            this.REFRESH.UseVisualStyleBackColor = false;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(717, 246);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(163, 28);
            this.quantity.TabIndex = 15;
            this.quantity.Text = "DESCRIPTION";
            this.quantity.Click += new System.EventHandler(this.quantity_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(908, 245);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(275, 31);
            this.D.TabIndex = 16;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = RestaurantManager.AppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSEARCH.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSEARCH.Image = ((System.Drawing.Image)(resources.GetObject("btnSEARCH.Image")));
            this.btnSEARCH.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSEARCH.Location = new System.Drawing.Point(18, 399);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(178, 42);
            this.btnSEARCH.TabIndex = 17;
            this.btnSEARCH.Text = "   SEARCH         ";
            this.btnSEARCH.UseVisualStyleBackColor = false;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Total.ForeColor = System.Drawing.Color.Fuchsia;
            this.Total.Location = new System.Drawing.Point(818, 409);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(283, 48);
            this.Total.TabIndex = 18;
            this.Total.Text = "$ TOTAL $";
            this.Total.UseVisualStyleBackColor = false;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // STARTOVER
            // 
            this.STARTOVER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.STARTOVER.ForeColor = System.Drawing.Color.Fuchsia;
            this.STARTOVER.Location = new System.Drawing.Point(751, 3);
            this.STARTOVER.Name = "STARTOVER";
            this.STARTOVER.Size = new System.Drawing.Size(211, 58);
            this.STARTOVER.TabIndex = 19;
            this.STARTOVER.Text = "START OVER";
            this.STARTOVER.UseVisualStyleBackColor = false;
            this.STARTOVER.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FINISHORDER
            // 
            this.FINISHORDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FINISHORDER.ForeColor = System.Drawing.Color.Fuchsia;
            this.FINISHORDER.Location = new System.Drawing.Point(972, 3);
            this.FINISHORDER.Name = "FINISHORDER";
            this.FINISHORDER.Size = new System.Drawing.Size(211, 58);
            this.FINISHORDER.TabIndex = 20;
            this.FINISHORDER.Text = "FINISH ORDER";
            this.FINISHORDER.UseVisualStyleBackColor = false;
            this.FINISHORDER.Click += new System.EventHandler(this.FINISHORDER_Click);
            // 
            // dgvFinishOrder
            // 
            this.dgvFinishOrder.AllowUserToAddRows = false;
            this.dgvFinishOrder.AllowUserToDeleteRows = false;
            this.dgvFinishOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinishOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFinishOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinishOrder.Location = new System.Drawing.Point(19, 552);
            this.dgvFinishOrder.Name = "dgvFinishOrder";
            this.dgvFinishOrder.ReadOnly = true;
            this.dgvFinishOrder.RowHeadersWidth = 82;
            this.dgvFinishOrder.RowTemplate.Height = 33;
            this.dgvFinishOrder.Size = new System.Drawing.Size(1164, 155);
            this.dgvFinishOrder.TabIndex = 21;
            this.dgvFinishOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvFinishOrder.DoubleClick += new System.EventHandler(this.dgvFinishOrder_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(884, 516);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 31);
            this.textBox2.TabIndex = 25;
            // 
            // deleteOrder
            // 
            this.deleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteOrder.ForeColor = System.Drawing.Color.Fuchsia;
            this.deleteOrder.Location = new System.Drawing.Point(580, 509);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(131, 43);
            this.deleteOrder.TabIndex = 27;
            this.deleteOrder.Text = "DELETE";
            this.deleteOrder.UseVisualStyleBackColor = false;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(18, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 67);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "COMPLETED ORDERS";
            // 
            // totalVal
            // 
            this.totalVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totalVal.ForeColor = System.Drawing.Color.Fuchsia;
            this.totalVal.Location = new System.Drawing.Point(457, 509);
            this.totalVal.Name = "totalVal";
            this.totalVal.Size = new System.Drawing.Size(117, 43);
            this.totalVal.TabIndex = 29;
            this.totalVal.Text = "TOTAL$";
            this.totalVal.UseVisualStyleBackColor = false;
            this.totalVal.Click += new System.EventHandler(this.totalVal_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(749, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalVal);
            this.Controls.Add(this.dgvFinishOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FINISHORDER);
            this.Controls.Add(this.STARTOVER);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.btnSEARCH);
            this.Controls.Add(this.D);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.BTNCLEAR);
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
            this.Size = new System.Drawing.Size(1203, 907);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishOrder)).EndInit();
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
        private System.Windows.Forms.Button BTNCLEAR;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox D;
        private AppDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button STARTOVER;
        private System.Windows.Forms.Button FINISHORDER;
        private System.Windows.Forms.DataGridView dgvFinishOrder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button totalVal;
        private System.Windows.Forms.Button button1;
    }
}
