using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public partial class Food : UserControl
    {
        string connectionString = "server=98.115.187.178;port=9005;user=root;password=root;database=Restaurant;";

        public Food()
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.GridFill();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "sandwhich";
                int MenuItemCost = 10;


                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Submitted to Order Successfully!");



                OrderItem orderItem = new OrderItem();

                orderItem.GridFill();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "burger";
                int MenuItemCost = 12;


                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Submitted to Order Successfully!");



                OrderItem orderItem = new OrderItem();

                orderItem.GridFill();



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "pizza";
                int MenuItemCost = 13;


                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Submitted to Order Successfully!");



                OrderItem orderItem = new OrderItem();

                orderItem.GridFill();



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "chicken";
                int MenuItemCost = 9;


                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Submitted to Order Successfully!");



                OrderItem orderItem = new OrderItem();

                orderItem.GridFill();



            }
        }
    }
}
