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
    public partial class Signin : Form
    {

        public User user;
        public Signin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MySQLConnection db = new MySQLConnection();
            db.OpenConn();
            String username = textBox2.Text;
            String password = textBox3.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM login WHERE user_name = @usn and passwords = @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlCommand command2 = new MySqlCommand("SELECT id FROM login WHERE user_name = @user", db.getConnection());
            command2.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            MySqlDataReader reader = null;
            int id = 0;
            try
            {
                reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("! " + e.ToString());
            }
            user = setUser(id);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Logged in");
                var nextForm = new MainPage(user);
                nextForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Not logged in");
            }

           


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var nextForm = new Signup();
            nextForm.Show();
            this.Close(); 
        }

        public User setUser(int userID)
        {

            MySQLConnection db = new MySQLConnection();
            MySqlCommand command = new MySqlCommand("SELECT parent_id FROM staff_info WHERE id = @userID", db.getConnection());
            command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID;
            MySqlDataReader reader = null;

            int permissionLevel = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permissionLevel = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }

            User newUser = new User(permissionLevel);
            return newUser;
            /*
            MySqlCommand command2 = new MySqlCommand("SELECT username FROM staff_info WHERE userID = @userID", db.getConnection());
            command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID;
            

            int permissionLevel = 0;
            try
            {
                reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    permissionLevel = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }
            User newUser = new User();
            */
        }
    }
}
