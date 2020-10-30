using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Load += Menu_Load;

        }


        private void x_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
        private void SetActivePanel(UserControl control) 
        {
           


        
        }
        private void DRINKS_Click(object sender, EventArgs e)
        {
           

        }

        private void SNACKS_Click(object sender, EventArgs e)
        {
        }

        private void FOOD_Click(object sender, EventArgs e)
        {
           
        }

        private void DESSERT_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Welcome();
            nextForm.Show();
        }
    }
}
