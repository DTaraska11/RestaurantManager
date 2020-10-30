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
    public partial class MainEmployee : Form
    {
        public MainEmployee()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var nextForm = new Menu();
            nextForm.Show();
            this.Hide();
        }
    }
}
