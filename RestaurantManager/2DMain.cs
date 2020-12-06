using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public partial class _2DMain : Form
    {
        
        public _2DMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new StockClass();
            nextForm.Show();
            
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            var nextForm = new StaffInfo();
            nextForm.Show();
            
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var nextForm = new Menu();
            nextForm.Show();
            
        }

        private void OccupancyButton_Click(object sender, EventArgs e)
        {
            var nextForm = new FloorInfo();
            nextForm.Show();
            
        }

        private void _2DMain_Load(object sender, EventArgs e)
        {

            
            StockButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            StaffButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            StockButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            StaffButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            OccupancyButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            OccupancyButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            OrderButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            OrderButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            OrderInfoButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            OrderInfoButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            statButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            statButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            setTableSeating();
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void OrderInfoButton_Click(object sender, EventArgs e)
        {
            var nextForm = new OrderInfo();
            nextForm.Show();
            
        }

        public void setTableSeating()
        {

            MySQLConnection db = new MySQLConnection();
            db.OpenConn();
            MySqlCommand command = new MySqlCommand("SELECT taken FROM table_info WHERE tableID = 1", db.getConnection());
            MySqlDataReader reader = null;

            int taken = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    taken = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            command = new MySqlCommand("SELECT clean FROM table_info WHERE tableID = 1", db.getConnection());
            reader = null;

            int clean = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clean = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            if (taken == 1)
            {
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                if (clean == 1)
                {
                    pictureBox1.BackColor = Color.Green;
                }
                else
                {
                    pictureBox1.BackColor = Color.Orange;
                }
            }

            command = new MySqlCommand("SELECT taken FROM table_info WHERE tableID = 2", db.getConnection());
            //command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID;
            reader = null;

            taken = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    taken = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            command = new MySqlCommand("SELECT clean FROM table_info WHERE tableID = 2", db.getConnection());
            reader = null;

            clean = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clean = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            if (taken == 1)
            {
                pictureBox2.BackColor = Color.Red;
            }
            else
            {
                if (clean == 1)
                {
                    pictureBox2.BackColor = Color.Green;
                }
                else
                {
                    pictureBox2.BackColor = Color.Orange;
                }
            }

            command = new MySqlCommand("SELECT taken FROM table_info WHERE tableID = 3", db.getConnection());
            //command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID;
            reader = null;

            taken = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    taken = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            command = new MySqlCommand("SELECT clean FROM table_info WHERE tableID = 3", db.getConnection());
            reader = null;
            clean = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clean = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            if (taken == 1)
            {
                pictureBox3.BackColor = Color.Red;
            }
            else
            {
                if (clean == 1)
                {
                    pictureBox3.BackColor = Color.Green;
                }
                else
                {
                    pictureBox3.BackColor = Color.Orange;
                }
            }
            db.CloseConn();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MySQLConnection db = new MySQLConnection();
            db.OpenConn();
            MySqlCommand command = new MySqlCommand("UPDATE `Restaurant`.`table_info` SET `taken` = @taken,`clean` = @clean WHERE tableID = 1;", db.getConnection());

            MySqlCommand command2 = new MySqlCommand("SELECT taken FROM table_info WHERE tableID = 1", db.getConnection());
            MySqlDataReader reader = null;
            int taken = 0;
            try
            {
                reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    taken = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show("! " + e.ToString());
            }
            command2 = new MySqlCommand("SELECT clean FROM table_info WHERE tableID = 1", db.getConnection());
            reader = null;
            int clean = 0;
            try
            {
                reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    clean = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show("! " + e.ToString());
            }



            if(taken == 1)
            {
                command.Parameters.Add("@taken", MySqlDbType.Int16).Value = 0;
                command.Parameters.Add("@clean", MySqlDbType.Int16).Value = 0;
            }
            else if(taken == 0 && clean == 0)
            {
                command.Parameters.Add("@taken", MySqlDbType.Int16).Value = 0;
                command.Parameters.Add("@clean", MySqlDbType.Int16).Value = 1;
            }
            else
            {
                command.Parameters.Add("@taken", MySqlDbType.Int16).Value = 1;
                command.Parameters.Add("@clean", MySqlDbType.Int16).Value = 0;
            }
            
            command.ExecuteNonQuery();
            db.CloseConn();
            
            setTableSeating();


        }

        private void statButton_Click(object sender, EventArgs e)
        {
            var nextForm = new Statistics();
            nextForm.Show();
        }
    }
}
