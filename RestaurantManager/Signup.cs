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
        public Signup()
        {
            InitializeComponent();
        }

      

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void butSignUp_Click(object sender, EventArgs e)
        {
            //empty name field
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter your name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO login (user_name,passwords) VALUES (@un,@pass)", db.getConnection());
                mySqlCommand.Parameters.Add("@un", MySqlDbType.VarChar).Value = txtFullName.Text;
                mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text;


                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account created");
                    var nextForm = new MainPage();
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
    }
}
