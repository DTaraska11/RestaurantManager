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
    public partial class Drinks : UserControl
    {
        string connectionString = "server=98.115.187.178;port=9005;user=root;password=root;database=Restaurant;";
        
        public Drinks()
        {
            InitializeComponent();
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   int id = 0;
            string item_name = "coffee";
            int item_cost = 5;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__MenuItemID", id);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", item_name);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", item_cost);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                
            }
        }
    }
}
