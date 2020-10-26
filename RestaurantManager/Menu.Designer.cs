namespace RestaurantManager
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.FOOD = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogOut = new System.Windows.Forms.Button();
            this.SNACKS = new System.Windows.Forms.Button();
            this.Drinks = new System.Windows.Forms.Button();
            this.Dessert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FOOD
            // 
            this.FOOD.BackColor = System.Drawing.Color.White;
            this.FOOD.ForeColor = System.Drawing.Color.LimeGreen;
            this.FOOD.Image = ((System.Drawing.Image)(resources.GetObject("FOOD.Image")));
            this.FOOD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FOOD.Location = new System.Drawing.Point(245, 0);
            this.FOOD.Name = "FOOD";
            this.FOOD.Size = new System.Drawing.Size(129, 153);
            this.FOOD.TabIndex = 7;
            this.FOOD.Text = "FOOD";
            this.FOOD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FOOD.UseVisualStyleBackColor = false;
            this.FOOD.Click += new System.EventHandler(this.x_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Dessert);
            this.panel2.Controls.Add(this.Drinks);
            this.panel2.Controls.Add(this.SNACKS);
            this.panel2.Controls.Add(this.FOOD);
            this.panel2.Location = new System.Drawing.Point(12, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 152);
            this.panel2.TabIndex = 16;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 84);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(155, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 59);
            this.button9.TabIndex = 5;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(277, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(193, 59);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(639, 62);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(476, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 59);
            this.button11.TabIndex = 8;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(585, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 59);
            this.button12.TabIndex = 10;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Ink Free", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Orchid;
            this.textBox2.Location = new System.Drawing.Point(74, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 53);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "search menu";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.LavenderBlush;
            this.LogOut.Font = new System.Drawing.Font("Lucida Console", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogOut.Location = new System.Drawing.Point(475, 82);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(166, 56);
            this.LogOut.TabIndex = 20;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            // 
            // SNACKS
            // 
            this.SNACKS.BackColor = System.Drawing.Color.White;
            this.SNACKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SNACKS.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SNACKS.Image = ((System.Drawing.Image)(resources.GetObject("SNACKS.Image")));
            this.SNACKS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SNACKS.Location = new System.Drawing.Point(124, 0);
            this.SNACKS.Name = "SNACKS";
            this.SNACKS.Size = new System.Drawing.Size(125, 151);
            this.SNACKS.TabIndex = 8;
            this.SNACKS.Text = "SNACKS";
            this.SNACKS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SNACKS.UseVisualStyleBackColor = false;
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.SystemColors.Window;
            this.Drinks.ForeColor = System.Drawing.Color.BlueViolet;
            this.Drinks.Image = ((System.Drawing.Image)(resources.GetObject("Drinks.Image")));
            this.Drinks.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Drinks.Location = new System.Drawing.Point(3, 0);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(128, 153);
            this.Drinks.TabIndex = 11;
            this.Drinks.Text = "DRINKS";
            this.Drinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Drinks.UseVisualStyleBackColor = false;
            // 
            // Dessert
            // 
            this.Dessert.BackColor = System.Drawing.SystemColors.Window;
            this.Dessert.ForeColor = System.Drawing.Color.DeepPink;
            this.Dessert.Image = ((System.Drawing.Image)(resources.GetObject("Dessert.Image")));
            this.Dessert.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dessert.Location = new System.Drawing.Point(370, 1);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(119, 150);
            this.Dessert.TabIndex = 12;
            this.Dessert.Text = "DESSERT";
            this.Dessert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dessert.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(488, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 149);
            this.button1.TabIndex = 13;
            this.button1.Text = "MY CART";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Reservations.png");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 331);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(616, 424);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 798);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FOOD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Dessert;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.Button SNACKS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}