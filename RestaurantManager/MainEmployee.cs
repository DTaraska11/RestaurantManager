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
    public partial class MainEmployee : Form
    {
        public MainEmployee()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Welcome();
            nextForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StockClass stock = new StockClass();
            stock.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var nextForm = new Menu();
            nextForm.ShowDialog();
        }

        private void MainEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
