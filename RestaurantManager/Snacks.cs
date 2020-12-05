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
    public partial class Snacks : UserControl
    {
        string connectionString = "server=98.115.187.178;port=9005;user=root;password=root;database=Restaurant;"; 

        public Snacks()
        {
            InitializeComponent();
        }

        private void drinks1_Load(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.GridFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "fries";
                int MenuItemCost = 4;
                string D = " ";


                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.Parameters.AddWithValue("_Description", D);
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
                string MenuItemName = "bread";
                int MenuItemCost = 2;
                string D = " ";

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.Parameters.AddWithValue("_Description", D);
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
                string MenuItemName = "hotdog";
                int MenuItemCost = 7;
                string D = " ";

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.Parameters.AddWithValue("_Description", D);
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
                string MenuItemName = "pretzel";
                int MenuItemCost = 5;
                string D = " ";

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.Parameters.AddWithValue("_Description", D);
                mySqlCmd.ExecuteNonQuery();
                
                DialogResult result= MessageBox.Show("Submitted to Order Successfully!");

              
                
                    OrderItem orderItem = new OrderItem();

                    orderItem.GridFill();

                

            }
        }
    }
}
