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
            SetActivePanel(drinks1);
        }
        private void SetActivePanel(UserControl control) 
        {
            // disable controls
            drinks1.Visible = false;
            snacks1.Visible = false;
            food1.Visible = false;
            dessert1.Visible = false;
            myCart1.Visible = false;

            //enable control
            control.Visible = true;


        
        }
        private void DRINKS_Click(object sender, EventArgs e)
        {
            SetActivePanel(drinks1);

        }

        private void SNACKS_Click(object sender, EventArgs e)
        {
            SetActivePanel(snacks1);
        }

        private void FOOD_Click(object sender, EventArgs e)
        {
            SetActivePanel(food1);
        }

        private void DESSERT_Click(object sender, EventArgs e)
        {
            SetActivePanel(dessert1);
        }
    }
}
