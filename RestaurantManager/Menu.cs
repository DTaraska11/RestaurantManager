using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Load += Menu_Load;

        }


        private void x_Click(object sender, EventArgs e)
        {
            //food
            drinks2.Hide();
            snacks2.Hide();
            myCart2.Hide();
            dessert2.Hide();
            food2.Show();
            food2.BringToFront();


        }

        private void Menu_Load(object sender, EventArgs e)
        {

            snacks2.Hide();
            food2.Hide();
            dessert2.Hide();
            myCart2.Hide();

        }
        private void SetActivePanel(UserControl control)
        {




        }
        private void DRINKS_Click(object sender, EventArgs e)
        {

            snacks2.Hide();
            food2.Hide();
            dessert2.Hide();
            myCart2.Hide();
            drinks2.Show();
            drinks2.BringToFront();

        }

        private void SNACKS_Click(object sender, EventArgs e)
        {

            drinks2.Hide();
            food2.Hide();
            dessert2.Hide();
            myCart2.Hide();

            snacks2.Show();
            snacks2.BringToFront();

        }


        private void DESSERT_Click(object sender, EventArgs e)
        {
            drinks2.Hide();
            snacks2.Hide();
            food2.Hide();
            myCart2.Hide();
            dessert2.Show();
            dessert2.BringToFront();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Welcome();
            nextForm.Show();
        }

        private void MYCART_Click(object sender, EventArgs e)
        {
            drinks2.Hide();
            snacks2.Hide();
            dessert2.Hide();
            food2.Hide();
            myCart2.Show();
            myCart2.BringToFront();
        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Welcome();
            nextForm.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            StockClass stock = new StockClass();
            stock.ShowDialog();
        }

        private void ORDER_Click(object sender, EventArgs e)
        {
            drinks2.Hide();
            snacks2.Hide();
            food2.Hide();
         
            dessert2.Hide();   myCart2.Show();
            myCart2.BringToFront();
        }
    }
}
