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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.FOOD = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DRINKS = new System.Windows.Forms.Button();
            this.SNACKS = new System.Windows.Forms.Button();
            this.DESSERT = new System.Windows.Forms.Button();
            this.MYCART = new System.Windows.Forms.Button();
            this.TwoD = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.Reservation = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Stock = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.MenuPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dessert2 = new RestaurantManager.Dessert();
            this.drinks2 = new RestaurantManager.Drinks();
            this.food2 = new RestaurantManager.Food();
            this.snacks2 = new RestaurantManager.Snacks();
            this.myCart2 = new RestaurantManager.MyCart();
            this.usersTableAdapter1 = new RestaurantManager.AppDataSetTableAdapters.UsersTableAdapter();
            this.MenuPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.MenuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FOOD
            // 
            this.FOOD.BackColor = System.Drawing.Color.White;
            this.FOOD.ForeColor = System.Drawing.Color.LimeGreen;
            this.FOOD.Image = ((System.Drawing.Image)(resources.GetObject("FOOD.Image")));
            this.FOOD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FOOD.Location = new System.Drawing.Point(245, 1);
            this.FOOD.Name = "FOOD";
            this.FOOD.Size = new System.Drawing.Size(129, 150);
            this.FOOD.TabIndex = 7;
            this.FOOD.Text = "FOOD";
            this.FOOD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FOOD.UseVisualStyleBackColor = false;
            this.FOOD.Click += new System.EventHandler(this.x_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.DRINKS);
            this.MenuPanel.Controls.Add(this.SNACKS);
            this.MenuPanel.Controls.Add(this.FOOD);
            this.MenuPanel.Controls.Add(this.DESSERT);
            this.MenuPanel.Controls.Add(this.MYCART);
            this.MenuPanel.Location = new System.Drawing.Point(12, 176);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(620, 152);
            this.MenuPanel.TabIndex = 16;
            // 
            // DRINKS
            // 
            this.DRINKS.BackColor = System.Drawing.SystemColors.Window;
            this.DRINKS.ForeColor = System.Drawing.Color.BlueViolet;
            this.DRINKS.Image = ((System.Drawing.Image)(resources.GetObject("DRINKS.Image")));
            this.DRINKS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DRINKS.Location = new System.Drawing.Point(3, 0);
            this.DRINKS.Name = "DRINKS";
            this.DRINKS.Size = new System.Drawing.Size(128, 153);
            this.DRINKS.TabIndex = 11;
            this.DRINKS.Text = "DRINKS";
            this.DRINKS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DRINKS.UseVisualStyleBackColor = false;
            this.DRINKS.Click += new System.EventHandler(this.DRINKS_Click);
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
            this.SNACKS.Click += new System.EventHandler(this.SNACKS_Click);
            // 
            // DESSERT
            // 
            this.DESSERT.BackColor = System.Drawing.SystemColors.Window;
            this.DESSERT.ForeColor = System.Drawing.Color.DeepPink;
            this.DESSERT.Image = ((System.Drawing.Image)(resources.GetObject("DESSERT.Image")));
            this.DESSERT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DESSERT.Location = new System.Drawing.Point(370, 1);
            this.DESSERT.Name = "DESSERT";
            this.DESSERT.Size = new System.Drawing.Size(119, 150);
            this.DESSERT.TabIndex = 12;
            this.DESSERT.Text = "DESSERT";
            this.DESSERT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DESSERT.UseVisualStyleBackColor = false;
            this.DESSERT.Click += new System.EventHandler(this.DESSERT_Click);
            // 
            // MYCART
            // 
            this.MYCART.BackColor = System.Drawing.Color.White;
            this.MYCART.ForeColor = System.Drawing.Color.Gold;
            this.MYCART.Image = ((System.Drawing.Image)(resources.GetObject("MYCART.Image")));
            this.MYCART.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MYCART.Location = new System.Drawing.Point(488, 0);
            this.MYCART.Name = "MYCART";
            this.MYCART.Size = new System.Drawing.Size(132, 149);
            this.MYCART.TabIndex = 13;
            this.MYCART.Text = "MY CART";
            this.MYCART.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MYCART.UseVisualStyleBackColor = false;
            // 
            // TwoD
            // 
            this.TwoD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TwoD.Image = ((System.Drawing.Image)(resources.GetObject("TwoD.Image")));
            this.TwoD.Location = new System.Drawing.Point(3, 3);
            this.TwoD.Name = "TwoD";
            this.TwoD.Size = new System.Drawing.Size(146, 84);
            this.TwoD.TabIndex = 1;
            this.TwoD.UseVisualStyleBackColor = false;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.White;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuButton.Location = new System.Drawing.Point(155, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(116, 59);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.UseVisualStyleBackColor = false;
            // 
            // Reservation
            // 
            this.Reservation.BackColor = System.Drawing.Color.White;
            this.Reservation.Image = ((System.Drawing.Image)(resources.GetObject("Reservation.Image")));
            this.Reservation.Location = new System.Drawing.Point(277, 3);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(193, 59);
            this.Reservation.TabIndex = 4;
            this.Reservation.UseVisualStyleBackColor = false;
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.TwoD);
            this.HomePanel.Controls.Add(this.MenuButton);
            this.HomePanel.Controls.Add(this.Reservation);
            this.HomePanel.Controls.Add(this.Stock);
            this.HomePanel.Controls.Add(this.User);
            this.HomePanel.Location = new System.Drawing.Point(2, 12);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(639, 62);
            this.HomePanel.TabIndex = 18;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.White;
            this.Stock.Image = ((System.Drawing.Image)(resources.GetObject("Stock.Image")));
            this.Stock.Location = new System.Drawing.Point(476, 3);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(103, 59);
            this.Stock.TabIndex = 8;
            this.Stock.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.White;
            this.User.Image = ((System.Drawing.Image)(resources.GetObject("User.Image")));
            this.User.Location = new System.Drawing.Point(585, 3);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(44, 59);
            this.User.TabIndex = 10;
            this.User.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Ink Free", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Orchid;
            this.search.Location = new System.Drawing.Point(5, 85);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(467, 53);
            this.search.TabIndex = 19;
            this.search.Text = "search menu";
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
            // MenuPanel2
            // 
            this.MenuPanel2.Controls.Add(this.drinks2);
            this.MenuPanel2.Controls.Add(this.dessert2);
            this.MenuPanel2.Controls.Add(this.food2);
            this.MenuPanel2.Controls.Add(this.snacks2);
            this.MenuPanel2.Controls.Add(this.myCart2);
            this.MenuPanel2.Location = new System.Drawing.Point(15, 331);
            this.MenuPanel2.Name = "MenuPanel2";
            this.MenuPanel2.Size = new System.Drawing.Size(619, 387);
            this.MenuPanel2.TabIndex = 21;
            // 
            // dessert2
            // 
            this.dessert2.AutoScroll = true;
            this.dessert2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dessert2.Location = new System.Drawing.Point(3, 396);
            this.dessert2.Name = "dessert2";
            this.dessert2.Size = new System.Drawing.Size(619, 387);
            this.dessert2.TabIndex = 3;
            // 
            // drinks2
            // 
            this.drinks2.AutoScroll = true;
            this.drinks2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.drinks2.Location = new System.Drawing.Point(3, 3);
            this.drinks2.Name = "drinks2";
            this.drinks2.Size = new System.Drawing.Size(619, 387);
            this.drinks2.TabIndex = 0;
            // 
            // food2
            // 
            this.food2.AutoScroll = true;
            this.food2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.food2.Location = new System.Drawing.Point(3, 789);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(619, 387);
            this.food2.TabIndex = 2;
            // 
            // snacks2
            // 
            this.snacks2.AutoScroll = true;
            this.snacks2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snacks2.Location = new System.Drawing.Point(3, 1182);
            this.snacks2.Name = "snacks2";
            this.snacks2.Size = new System.Drawing.Size(619, 387);
            this.snacks2.TabIndex = 1;
            // 
            // myCart2
            // 
            this.myCart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.myCart2.Location = new System.Drawing.Point(3, 1575);
            this.myCart2.Name = "myCart2";
            this.myCart2.Size = new System.Drawing.Size(619, 387);
            this.myCart2.TabIndex = 5;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 798);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.MenuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.MenuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FOOD;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button TwoD;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button Reservation;
        private System.Windows.Forms.FlowLayoutPanel HomePanel;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button DESSERT;
        private System.Windows.Forms.Button DRINKS;
        private System.Windows.Forms.Button SNACKS;
        private System.Windows.Forms.Button MYCART;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel2;
        private AppDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private Drinks drinks1;
        private Snacks snacks1;
        private Food food1;
        private Dessert dessert1;
        private MyCart myCart1;
        private Drinks drinks2;
        private Food food2;
        private Snacks snacks2;
        private Dessert dessert2;
        private MyCart myCart2;
    }
}