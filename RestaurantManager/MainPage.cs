using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public partial class MainPage : Form
    {

        User user;
        public MainPage(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            int userAuth = user.getAuthority();
            if( userAuth != 1)
            {
                button8.Enabled = false;
                button5.Enabled = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Menu();
            nextForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Welcome();
            nextForm.Show();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            StockClass stock = new StockClass(user.getAuthority());
             stock.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            var nextForm = new StaffInfo(user.getAuthority());
            nextForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new _2DMain();
            nextForm.Show();
        }
    }
}
