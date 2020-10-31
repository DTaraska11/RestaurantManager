namespace RestaurantManager
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_save = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_finished = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lab_position = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comBox_gender = new System.Windows.Forms.ComboBox();
            this.lab_mail = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lab_SSN = new System.Windows.Forms.Label();
            this.txt_SSN = new System.Windows.Forms.TextBox();
            this.lab_birthday = new System.Windows.Forms.Label();
            this.lab_Gender = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lab_Phone = new System.Windows.Forms.Label();
            this.lab_Address = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 510);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.treeView1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 35);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(228, 475);
            this.panel8.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(228, 475);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "admin.png");
            this.imageList1.Images.SetKeyName(2, "add.png");
            this.imageList1.Images.SetKeyName(3, "cancel.png");
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.toolStrip1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 35);
            this.panel7.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStrip_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(228, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 32);
            this.toolStripButton1.Text = "ADD";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(63, 32);
            this.toolStripButton2.Text = "Edit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStrip_save
            // 
            this.toolStrip_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_save.Image")));
            this.toolStrip_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_save.Name = "toolStrip_save";
            this.toolStrip_save.Size = new System.Drawing.Size(66, 32);
            this.toolStrip_save.Text = "save";
            this.toolStrip_save.Click += new System.EventHandler(this.toolStrip_save_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_finished);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(228, 456);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 54);
            this.panel2.TabIndex = 1;
            // 
            // btn_finished
            // 
            this.btn_finished.Enabled = false;
            this.btn_finished.Location = new System.Drawing.Point(1085, 15);
            this.btn_finished.Margin = new System.Windows.Forms.Padding(2);
            this.btn_finished.Name = "btn_finished";
            this.btn_finished.Size = new System.Drawing.Size(83, 23);
            this.btn_finished.TabIndex = 2;
            this.btn_finished.Text = "Finish";
            this.btn_finished.UseVisualStyleBackColor = true;
            this.btn_finished.Visible = false;
            this.btn_finished.Click += new System.EventHandler(this.btn_finished_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(498, 15);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(83, 23);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(22, 15);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmb_position);
            this.panel3.Controls.Add(this.lab_position);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.comBox_gender);
            this.panel3.Controls.Add(this.lab_mail);
            this.panel3.Controls.Add(this.txt_Email);
            this.panel3.Controls.Add(this.lab_SSN);
            this.panel3.Controls.Add(this.txt_SSN);
            this.panel3.Controls.Add(this.lab_birthday);
            this.panel3.Controls.Add(this.lab_Gender);
            this.panel3.Controls.Add(this.txt_Address);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lab_Phone);
            this.panel3.Controls.Add(this.lab_Address);
            this.panel3.Controls.Add(this.txt_Phone);
            this.panel3.Controls.Add(this.lab_name);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(228, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 456);
            this.panel3.TabIndex = 2;
            // 
            // cmb_position
            // 
            this.cmb_position.Enabled = false;
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Items.AddRange(new object[] {
            "Admin",
            "Waiter",
            "Chef",
            "Manager"});
            this.cmb_position.Location = new System.Drawing.Point(95, 114);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(62, 21);
            this.cmb_position.TabIndex = 18;
            // 
            // lab_position
            // 
            this.lab_position.AutoSize = true;
            this.lab_position.Location = new System.Drawing.Point(42, 114);
            this.lab_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_position.Name = "lab_position";
            this.lab_position.Size = new System.Drawing.Size(44, 13);
            this.lab_position.TabIndex = 17;
            this.lab_position.Text = "Position";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 220);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comBox_gender
            // 
            this.comBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_gender.FormattingEnabled = true;
            this.comBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comBox_gender.Location = new System.Drawing.Point(95, 82);
            this.comBox_gender.Margin = new System.Windows.Forms.Padding(2);
            this.comBox_gender.Name = "comBox_gender";
            this.comBox_gender.Size = new System.Drawing.Size(62, 21);
            this.comBox_gender.TabIndex = 15;
            // 
            // lab_mail
            // 
            this.lab_mail.AutoSize = true;
            this.lab_mail.Location = new System.Drawing.Point(45, 287);
            this.lab_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_mail.Name = "lab_mail";
            this.lab_mail.Size = new System.Drawing.Size(32, 13);
            this.lab_mail.TabIndex = 14;
            this.lab_mail.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(94, 284);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(277, 20);
            this.txt_Email.TabIndex = 13;
            // 
            // lab_SSN
            // 
            this.lab_SSN.AutoSize = true;
            this.lab_SSN.Location = new System.Drawing.Point(45, 254);
            this.lab_SSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_SSN.Name = "lab_SSN";
            this.lab_SSN.Size = new System.Drawing.Size(29, 13);
            this.lab_SSN.TabIndex = 12;
            this.lab_SSN.Text = "SSN";
            // 
            // txt_SSN
            // 
            this.txt_SSN.Location = new System.Drawing.Point(94, 252);
            this.txt_SSN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.ReadOnly = true;
            this.txt_SSN.Size = new System.Drawing.Size(277, 20);
            this.txt_SSN.TabIndex = 11;
            // 
            // lab_birthday
            // 
            this.lab_birthday.AutoSize = true;
            this.lab_birthday.Location = new System.Drawing.Point(45, 223);
            this.lab_birthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_birthday.Name = "lab_birthday";
            this.lab_birthday.Size = new System.Drawing.Size(45, 13);
            this.lab_birthday.TabIndex = 10;
            this.lab_birthday.Text = "Birthday";
            // 
            // lab_Gender
            // 
            this.lab_Gender.AutoSize = true;
            this.lab_Gender.Location = new System.Drawing.Point(45, 82);
            this.lab_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Gender.Name = "lab_Gender";
            this.lab_Gender.Size = new System.Drawing.Size(42, 13);
            this.lab_Gender.TabIndex = 8;
            this.lab_Gender.Text = "Gender";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(94, 185);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(277, 20);
            this.txt_Address.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(433, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 452);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 247);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 247);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 205);
            this.panel5.TabIndex = 0;
            // 
            // lab_Phone
            // 
            this.lab_Phone.AutoSize = true;
            this.lab_Phone.Location = new System.Drawing.Point(45, 147);
            this.lab_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Phone.Name = "lab_Phone";
            this.lab_Phone.Size = new System.Drawing.Size(38, 13);
            this.lab_Phone.TabIndex = 5;
            this.lab_Phone.Text = "Phone";
            // 
            // lab_Address
            // 
            this.lab_Address.AutoSize = true;
            this.lab_Address.Location = new System.Drawing.Point(45, 185);
            this.lab_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Address.Name = "lab_Address";
            this.lab_Address.Size = new System.Drawing.Size(45, 13);
            this.lab_Address.TabIndex = 3;
            this.lab_Address.Text = "Address";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(94, 147);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.ReadOnly = true;
            this.txt_Phone.Size = new System.Drawing.Size(277, 20);
            this.txt_Phone.TabIndex = 2;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(45, 54);
            this.lab_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(35, 13);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(95, 54);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(277, 20);
            this.txt_name.TabIndex = 0;
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StaffInfo";
            this.Text = "Staff Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffInfo_FormClosed);
            this.Load += new System.EventHandler(this.PersonalInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lab_mail;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lab_SSN;
        private System.Windows.Forms.TextBox txt_SSN;
        private System.Windows.Forms.Label lab_birthday;
        private System.Windows.Forms.Label lab_Gender;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lab_Phone;
        private System.Windows.Forms.Label lab_Address;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox comBox_gender;
        private System.Windows.Forms.Button btn_finished;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lab_position;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrip_save;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btn_add;
    }
}

