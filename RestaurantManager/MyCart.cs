﻿using System;
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
            Clear();
            GridFill();
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
                Clear();
                GridFill();

            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MenuItemViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblMenuItem = new DataTable();
                sqlDa.Fill(dtblMenuItem);
                dgvMenuItem.DataSource = dtblMenuItem;
                dgvMenuItem.Columns[0].Visible = false;
            }
        }


        void Clear()
        {
            MenuItemName.Text  = MenuItemCost.Text = "";
            MenuItemID = 0;
            ADD.Text = "Save";
            DELETE.Enabled = false;
        }

        private void Search_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MenuItemDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MenuItemID", MenuItemID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();

            }
        }

        private void dgvMenuItem_DoubleClick(object sender, System.EventArgs e)
        {
            if (dgvMenuItem.CurrentRow.Index != -1)
            {
                MenuItemName.Text = dgvMenuItem.CurrentRow.Cells[1].Value.ToString();
                MenuItemCost.Text = dgvMenuItem.CurrentRow.Cells[2].Value.ToString();

                MenuItemID = Convert.ToInt32(dgvMenuItem.CurrentRow.Cells[0].Value.ToString());
                ADD.Text = "Update";
                DELETE.Enabled = Enabled;
            }
        }

       
        private void button1_Click_2(object sender, EventArgs e)
        {
            Clear();
        }
    }

}
