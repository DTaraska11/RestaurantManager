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

        private async void butSignUp_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConfirmPass.Text)
            {
                if(txtPass.Text!= txtConfirmPass.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Message", MessageBoxButtons.OK ,MessageBoxIcon.Warning);

                }
                return;
            }

            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User() { FullName = txtFullName.Text, Password = txtPass.Text, Email = txtEmail.Text, UserType = UserType.Text });
            if (result)
                MessageBox.Show("You have successfully signed up!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
