namespace RestaurantManager
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.label2 = new System.Windows.Forms.Label();
            this.butSignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MV Boli", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(-30, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "        SIGN UP             ";
            // 
            // butSignUp
            // 
            this.butSignUp.BackColor = System.Drawing.Color.White;
            this.butSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSignUp.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSignUp.ForeColor = System.Drawing.Color.Crimson;
            this.butSignUp.Location = new System.Drawing.Point(108, 329);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(116, 23);
            this.butSignUp.TabIndex = 6;
            this.butSignUp.Text = "SIGN UP";
            this.butSignUp.UseVisualStyleBackColor = false;
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.UserType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(47, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 151);
            this.panel1.TabIndex = 12;
            // 
            // UserType
            // 
            this.UserType.AllowDrop = true;
            this.UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Manager",
            "Owner"});
            this.UserType.Location = new System.Drawing.Point(128, 114);
            this.UserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(101, 21);
            this.UserType.TabIndex = 13;
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(36, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 11);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("NSimSun", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 11);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NSimSun", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(48, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 11);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(128, 89);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(101, 20);
            this.txtConfirmPass.TabIndex = 8;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(128, 67);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(101, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(128, 22);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(101, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(101, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(54, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 11);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.Location = new System.Drawing.Point(82, 369);
            this.labMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(0, 13);
            this.labMsg.TabIndex = 13;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(319, 415);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butSignUp);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label labMsg;
    }
}