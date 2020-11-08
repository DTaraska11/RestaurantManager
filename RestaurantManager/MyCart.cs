using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public partial class OrderItem : UserControl
    {
        string connectionString = "server=98.115.187.178;port=9005;user=root;password=root;database=Restaurant;";
        int MenuItemID = 0;
        public OrderItem()
        {
            InitializeComponent();
        }

        private void OrderItem_Load(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
         
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                

            }
        }
    }
}
