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
    public partial class FloorInfo : Form
    {
        public FloorInfo()
        {
            InitializeComponent();
        }

        private void FloorInfo_Load(object sender, EventArgs e)
        {
            
            MySQLConnection db = new MySQLConnection();
            db.OpenConn();
            String cmmd = "SELECT * FROM reservation";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmmd, db.getConnection());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "reservation");
            db.CloseConn();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "reservation";


        }
    }
}
