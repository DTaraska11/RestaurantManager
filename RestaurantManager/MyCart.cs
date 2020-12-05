using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void OrderItem_Load(object sender, EventArgs e)
        {
            Refresh();
            Update();
            Clear();
            GridFill();
            FinishOrderGridFill();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemAddOrEdit", mysqlCon);
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.Parameters.AddWithValue("_MenuItemName", MenuItemName.Text);
                mySqlCmd.Parameters.AddWithValue("_MenuItemCost", MenuItemCost.Text);
                mySqlCmd.Parameters.AddWithValue("_Description", D.Text);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();

            }
        }


        public void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MenuItemViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblMenuItem = new DataTable();
                sqlDa.Fill(dtblMenuItem);
                dgvMenuItem.DataSource = typeof(Drinks);
                dgvMenuItem.DataSource = dtblMenuItem;
                dgvMenuItem.Columns[0].Visible = false;
                dgvMenuItem.Update();
                dgvMenuItem.Refresh();

            }
        }


        void Clear()
        {
            MenuItemName.Text = D.Text = MenuItemCost.Text = "";
            MenuItemID = 0;
            ADD.Text = "Save";
            DELETE.Enabled = false;
        }

        private void Search_TextChanged(object sender, System.EventArgs e)
        {

        }
        //delete button menu items
        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("MenuItemID", MenuItemID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();

            }
        }
        //click in menu item datagv table
        private void dgvMenuItem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMenuItem.CurrentRow.Index != -1)
            {



                MenuItemName.Text = dgvMenuItem.CurrentRow.Cells[1].Value.ToString();
                MenuItemCost.Text = dgvMenuItem.CurrentRow.Cells[2].Value.ToString();
                D.Text = dgvMenuItem.CurrentRow.Cells[3].Value.ToString();
                MenuItemID = Convert.ToInt32(dgvMenuItem.CurrentRow.Cells[0].Value.ToString());
                ADD.Text = "EDIT";
                DELETE.Enabled = Enabled;
            }
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            Clear();
        }

        private void REFRESH_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void MenuItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MenuItemSearchByValue", mysqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", Search.Text);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblMenuItem = new DataTable();
                sqlDa.Fill(dtblMenuItem);
                dgvMenuItem.DataSource = dtblMenuItem;
                dgvMenuItem.Columns[0].Visible = false;


            }
        }

        private void quantity_Click(object sender, EventArgs e)
        {

        }

        public int GetSum(int sum)
        {

            return (sum);
        }

        private void Total_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < dgvMenuItem.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvMenuItem.Rows[i].Cells[2].Value);
            }

            MessageBox.Show("Total $" + sum.ToString());
            GetSum(sum);
        }


        //delete all menu items
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemDeleteALLByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();

            }
        }





        public void FinishOrderGridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("FinishOrderViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dtblFinishOrder = new DataTable();
                sqlDa.Fill(dtblFinishOrder);

                dgvFinishOrder.DataSource = dtblFinishOrder;
                dgvFinishOrder.Columns[0].Visible = true;
                dgvFinishOrder.Update();
                dgvFinishOrder.Refresh();

            }
        }







        private void dgvFinishOrder_DoubleClick(object sender, EventArgs e)
        {



        }

        private void deleteOrder_Click_1(object sender, EventArgs e)
        {
            int FinishOrderID = 0;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("FinishOrderDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("FinishOrderID", FinishOrderID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");

                FinishOrderGridFill();

            }
        }




        private void FINISHORDER_Click(object sender, EventArgs e)
        {
            //for the subtotal column
            int sum = 0;
            for (int i = 0; i < dgvMenuItem.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvMenuItem.Rows[i].Cells[2].Value);
            }

            //for the tip column apply 15% tip 
            double tip = .15 * sum;
            //for the tip column
            double total = tip + sum;







            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("FinishOrder", mysqlCon);
                mySqlCmd.Parameters.AddWithValue("_sum", sum);
                mySqlCmd.Parameters.AddWithValue("_tip", tip);
                mySqlCmd.Parameters.AddWithValue("_total", total);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Order Complete");






                FinishOrderGridFill();



            }

        }

        private void totalVal_Click_1(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < dgvFinishOrder.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvFinishOrder.Rows[i].Cells[4].Value);
            }

            MessageBox.Show("Total Value $" + sum.ToString());
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("FinishOrderSearch", mysqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", Search.Text);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblMenuItem = new DataTable();
                sqlDa.Fill(dtblMenuItem);
                dgvFinishOrder.DataSource = dtblMenuItem;
                dgvFinishOrder.Columns[0].Visible = false;


            }
        }
    }
}