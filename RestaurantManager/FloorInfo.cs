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
            
            MySQLConnection dbFloor = new MySQLConnection();
            dbFloor.OpenConn();
            String cmmd = "SELECT * FROM reservation";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmmd, dbFloor.getConnection());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "reservation");
            dbFloor.CloseConn();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "reservation";


        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*
            MySQLConnection db = new MySQLConnection();
            db.OpenConn();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO reservation (user_name,passwords,id) VALUES (@un,@pass,@id)", db.getConnection());
            //mySqlCommand.Parameters.Add("@un", MySqlDbType.VarChar).Value = txtFullName.Text;
            //mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text;
            //mySqlCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = maxID + 1;

    */

            var nextForm = new MakeReservation();
            nextForm.Show();

        }
    }
}
