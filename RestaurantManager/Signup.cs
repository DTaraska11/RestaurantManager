using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public partial class Signup : Form
    {

        User user;

        public Signup()
        {
            InitializeComponent();
        }
        
        private void butSignUp_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox_FirstName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FirstName.Focus();
                String name = textBox_FirstName.Text;
                return;
            }
            if (string.IsNullOrEmpty(textBox_LastName.Text))
            {
                MessageBox.Show("Please enter a last name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_LastName.Focus();
                String name = textBox_LastName.Text;
                return;
            }
            //empty name field
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter a username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                String name = txtFullName.Text;
                return;
            }

            //empty email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                String email = txtEmail.Text;
                return;
            }

            //empty password
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                String pass = txtPass.Text;
                return;
            }

            //empty password
            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                MessageBox.Show("Please confirm your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPass.Focus();
                String conPass = txtConfirmPass.Text;
                return;
            }

            
        

            if (txtPass.Text != txtConfirmPass.Text)
            {
                if(txtPass.Text!= txtConfirmPass.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Message", MessageBoxButtons.OK ,MessageBoxIcon.Warning);

                }
                return;
            }

            MySQLConnection db = new MySQLConnection();
            db.OpenConn();
            if (checkUsername())
            {
                MessageBox.Show("This username already exists, please select a different one");
            }
            else
            {

                int maxID = getMaxID();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO login (user_name,passwords,id) VALUES (@un,@pass,@id)", db.getConnection());
                mySqlCommand.Parameters.Add("@un", MySqlDbType.VarChar).Value = txtFullName.Text;
                mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text;
                mySqlCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = maxID+1;


                MySqlCommand mySqlCommand2 = new MySqlCommand("INSERT INTO staff_info (first_name,last_name,id,email,parent_id,address_id,phone) VALUES (@un,@first,@last,@pass,@id,@email,@parent,@address,@phone)", db.getConnection());
                mySqlCommand2.Parameters.Add("@un", MySqlDbType.VarChar).Value = txtFullName.Text;
                mySqlCommand2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text;
                mySqlCommand2.Parameters.Add("@id", MySqlDbType.Int32).Value = maxID + 1;
                mySqlCommand2.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                mySqlCommand2.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBox_Address.Text;
                mySqlCommand2.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox_Phone.Text;
                mySqlCommand2.Parameters.Add("@first", MySqlDbType.VarChar).Value = textBox_FirstName.Text;
                mySqlCommand2.Parameters.Add("@last", MySqlDbType.VarChar).Value = textBox_LastName.Text;


                if (comboBox1.SelectedItem.Equals("Owner"))
                {
                    mySqlCommand2.Parameters.Add("@parent", MySqlDbType.Int32).Value = 1;
                }
                else
                {
                    mySqlCommand2.Parameters.Add("@parent", MySqlDbType.Int32).Value = 2;
                }
                mySqlCommand2.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBox_Address.Text;
                mySqlCommand2.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox_Phone.Text;



                if (mySqlCommand.ExecuteNonQuery() == 1 && mySqlCommand2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account created");
                    user = setUser(maxID + 1);
                    var nextForm = new MainPage(user);
                    nextForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account not created");
                }
                db.CloseConn();
            }
          
         
        }
        public int getMaxID()
        {
            int maxID = 0;
            
            MySQLConnection db = new MySQLConnection();
            MySqlCommand command = new MySqlCommand("SELECT MAX(id) FROM login", db.getConnection());
            MySqlDataReader reader = null;
            int maxID_login = 0;
            int maxID_staff = 0;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    maxID_login = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }


            MySqlCommand command2 = new MySqlCommand("SELECT MAX(id) FROM staff_info", db.getConnection());
            MySqlDataReader reader2 = null;
            
            
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    maxID_staff = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("! " + e.ToString());
            }




            if (maxID_login == maxID_staff)
            {
                return maxID_login;
            }
            else if (maxID_login > maxID_staff)
            {
                return maxID_login;
            }
            else
            {
                return maxID_staff;
            }

            

        }
        public Boolean checkUsername()
        {

            MySQLConnection db = new MySQLConnection();
            String username = txtFullName.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM login WHERE user_name = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
            
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var nextForm = new Signin();
            nextForm.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
