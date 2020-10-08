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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog(this); // if you need non-modal window
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.ShowDialog(this); // if you need non-modal window
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form4();
            form.ShowDialog(this); // if you need non-modal window
        }
    }
}
