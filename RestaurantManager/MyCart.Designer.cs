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
            this.SuspendLayout();
            // 
            // ORDERFORM
            // 
            this.ORDERFORM.Location = new System.Drawing.Point(232, 24);
            this.ORDERFORM.Name = "ORDERFORM";
            this.ORDERFORM.Size = new System.Drawing.Size(152, 31);
            this.ORDERFORM.TabIndex = 0;
            this.ORDERFORM.Text = "ORDER NOW";
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ORDERFORM);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(619, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ORDERFORM;
    }
}
