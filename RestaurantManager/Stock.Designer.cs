namespace RestaurantManager
{
    partial class StockClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboB_type1 = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_type1 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lab_qty = new System.Windows.Forms.Label();
            this.txt_safe = new System.Windows.Forms.TextBox();
            this.lab_safe = new System.Windows.Forms.Label();
            this.txt_name1 = new System.Windows.Forms.TextBox();
            this.lab_name1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_safe = new System.Windows.Forms.Button();
            this.comboB_type = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_type = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lab_ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 105);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 105);
            this.panel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboB_type1);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.lab_type1);
            this.groupBox2.Controls.Add(this.txt_qty);
            this.groupBox2.Controls.Add(this.lab_qty);
            this.groupBox2.Controls.Add(this.txt_safe);
            this.groupBox2.Controls.Add(this.lab_safe);
            this.groupBox2.Controls.Add(this.txt_name1);
            this.groupBox2.Controls.Add(this.lab_name1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert";
            // 
            // comboB_type1
            // 
            this.comboB_type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_type1.FormattingEnabled = true;
            this.comboB_type1.Items.AddRange(new object[] {
            "vegetable ",
            "Meat",
            "Seasoning"});
            this.comboB_type1.Location = new System.Drawing.Point(336, 65);
            this.comboB_type1.Name = "comboB_type1";
            this.comboB_type1.Size = new System.Drawing.Size(178, 21);
            this.comboB_type1.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(532, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 64);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_type1
            // 
            this.lab_type1.AutoSize = true;
            this.lab_type1.Location = new System.Drawing.Point(285, 70);
            this.lab_type1.Name = "lab_type1";
            this.lab_type1.Size = new System.Drawing.Size(31, 13);
            this.lab_type1.TabIndex = 6;
            this.lab_type1.Text = "Type";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(336, 22);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(178, 19);
            this.txt_qty.TabIndex = 5;
            // 
            // lab_qty
            // 
            this.lab_qty.AutoSize = true;
            this.lab_qty.Location = new System.Drawing.Point(285, 28);
            this.lab_qty.Name = "lab_qty";
            this.lab_qty.Size = new System.Drawing.Size(23, 13);
            this.lab_qty.TabIndex = 4;
            this.lab_qty.Text = "Qty";
            // 
            // txt_safe
            // 
            this.txt_safe.Location = new System.Drawing.Point(104, 64);
            this.txt_safe.Name = "txt_safe";
            this.txt_safe.Size = new System.Drawing.Size(134, 19);
            this.txt_safe.TabIndex = 3;
            // 
            // lab_safe
            // 
            this.lab_safe.AutoSize = true;
            this.lab_safe.Location = new System.Drawing.Point(21, 70);
            this.lab_safe.Name = "lab_safe";
            this.lab_safe.Size = new System.Drawing.Size(58, 13);
            this.lab_safe.TabIndex = 2;
            this.lab_safe.Text = "Safe stock";
            // 
            // txt_name1
            // 
            this.txt_name1.Location = new System.Drawing.Point(104, 25);
            this.txt_name1.Name = "txt_name1";
            this.txt_name1.Size = new System.Drawing.Size(134, 19);
            this.txt_name1.TabIndex = 1;
            // 
            // lab_name1
            // 
            this.lab_name1.AutoSize = true;
            this.lab_name1.Location = new System.Drawing.Point(21, 28);
            this.lab_name1.Name = "lab_name1";
            this.lab_name1.Size = new System.Drawing.Size(57, 13);
            this.lab_name1.TabIndex = 0;
            this.lab_name1.Text = "item Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(621, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 105);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_safe);
            this.groupBox1.Controls.Add(this.comboB_type);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lab_type);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.lab_name);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.lab_ID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_safe
            // 
            this.btn_safe.Location = new System.Drawing.Point(469, 18);
            this.btn_safe.Name = "btn_safe";
            this.btn_safe.Size = new System.Drawing.Size(62, 70);
            this.btn_safe.TabIndex = 2;
            this.btn_safe.Text = "safe stock";
            this.btn_safe.UseVisualStyleBackColor = true;
            this.btn_safe.Click += new System.EventHandler(this.btn_safe_Click);
            // 
            // comboB_type
            // 
            this.comboB_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_type.FormattingEnabled = true;
            this.comboB_type.Items.AddRange(new object[] {
            "All",
            "vegetable ",
            "Meat",
            "Seasoning"});
            this.comboB_type.Location = new System.Drawing.Point(68, 70);
            this.comboB_type.Name = "comboB_type";
            this.comboB_type.Size = new System.Drawing.Size(187, 21);
            this.comboB_type.TabIndex = 5;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(272, 62);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 28);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(272, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 28);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(24, 73);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(31, 13);
            this.lab_type.TabIndex = 3;
            this.lab_type.Text = "Type";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(68, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(187, 19);
            this.txt_name.TabIndex = 7;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(8, 49);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(54, 13);
            this.lab_name.TabIndex = 4;
            this.lab_name.Text = "itemName";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(68, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(187, 19);
            this.txt_id.TabIndex = 6;
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Location = new System.Drawing.Point(27, 26);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(18, 13);
            this.lab_ID.TabIndex = 2;
            this.lab_ID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 726);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 726);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // StockClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1164, 831);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StockClass";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox comboB_type;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Button btn_safe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboB_type1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lab_type1;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lab_qty;
        private System.Windows.Forms.TextBox txt_safe;
        private System.Windows.Forms.Label lab_safe;
        private System.Windows.Forms.TextBox txt_name1;
        private System.Windows.Forms.Label lab_name1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
    }
}