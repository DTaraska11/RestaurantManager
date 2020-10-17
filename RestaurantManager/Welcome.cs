using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new Signin();
            nextForm.Show();

        }


        private void button2_Click(object sender, EventArgs e)
                {
                    var nextForm = new Signup();
                    nextForm.Show();
                    
                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

    }
}
