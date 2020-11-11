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
using System.Security.AccessControl;

namespace RestaurantManager
{
    public partial class Drinks : UserControl
    {
        string connectionString = "server=98.115.187.178;port=9005;user=root;password=root;database=Restaurant;";




        public Drinks()
        {
            InitializeComponent();
        }

        private void Drinks_Load(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.GridFill();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "coffee";
                int MenuItemCost = 5;


                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost);
                mySqlCmd.ExecuteNonQuery();
                
                DialogResult result= MessageBox.Show("Submitted to Order Successfully!");

              
                
                    OrderItem orderItem = new OrderItem();

                    orderItem.GridFill();

                

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "tea";
                int MenuItemCost = 3;


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
                string MenuItemName = "alcohol";
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

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int MenuItemID = 0;
                string MenuItemName = "soda";
                int MenuItemCost = 4;


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

    
