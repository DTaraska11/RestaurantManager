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
            this.ORDERFORM = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._MenuItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MenuItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MenuItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDataSet1 = new RestaurantManager.AppDataSet();
            this.appDataSet2 = new RestaurantManager.AppDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuItemName = new System.Windows.Forms.TextBox();
            this.MenuItemCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._MenuItemID,
            this._MenuItemName,
            this._MenuItemCost});
            this.dataGridView1.Location = new System.Drawing.Point(18, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(584, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _MenuItemID
            // 
            this._MenuItemID.HeaderText = "ID";
            this._MenuItemID.MinimumWidth = 10;
            this._MenuItemID.Name = "_MenuItemID";
            this._MenuItemID.Width = 200;
            // 
            // _MenuItemName
            // 
            this._MenuItemName.HeaderText = "Name";
            this._MenuItemName.MinimumWidth = 10;
            this._MenuItemName.Name = "_MenuItemName";
            this._MenuItemName.Width = 200;
            // 
            // _MenuItemCost
            // 
            this._MenuItemCost.HeaderText = "Cost";
            this._MenuItemCost.MinimumWidth = 10;
            this._MenuItemCost.Name = "_MenuItemCost";
            this._MenuItemCost.Width = 200;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "COST";
            // 
            // MenuItemName
            // 
            this.MenuItemName.Location = new System.Drawing.Point(741, 60);
            this.MenuItemName.Name = "MenuItemName";
            this.MenuItemName.Size = new System.Drawing.Size(218, 31);
            this.MenuItemName.TabIndex = 9;
            // 
            // MenuItemCost
            // 
            this.MenuItemCost.Location = new System.Drawing.Point(740, 121);
            this.MenuItemCost.Name = "MenuItemCost";
            this.MenuItemCost.Size = new System.Drawing.Size(219, 31);
            this.MenuItemCost.TabIndex = 10;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.MenuItemCost);
            this.Controls.Add(this.MenuItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ORDERFORM);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(977, 387);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ORDERFORM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppDataSet appDataSet1;
        private AppDataSet appDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _MenuItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _MenuItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _MenuItemCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MenuItemName;
        private System.Windows.Forms.TextBox MenuItemCost;
    }
}
