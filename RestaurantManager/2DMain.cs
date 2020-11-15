using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class _2DMain : Form
    {
        public _2DMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new StockClass();
            nextForm.Show();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            var nextForm = new StaffInfo();
            nextForm.Show();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var nextForm = new Menu();
            nextForm.Show();
        }

        private void OccupancyButton_Click(object sender, EventArgs e)
        {
            var nextForm = new FloorInfo();
            nextForm.Show();
        }

        private void _2DMain_Load(object sender, EventArgs e)
        {
            StockButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            StaffButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            StockButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            StaffButton.FlatAppearance.MouseOverBackColor = Color.Transparent;



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void OrderInfoButton_Click(object sender, EventArgs e)
        {
            var nextForm = new OrderInfo();
            nextForm.Show();
        }
    }
}
