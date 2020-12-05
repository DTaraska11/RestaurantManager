using MySql.Data.MySqlClient;
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
    public partial class MakeReservation : Form
    {
        String time = "";
        
        public MakeReservation()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton10.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String d = monthCalendar1.SelectionRange.Start.ToShortDateString();
            //d = (d.Insert(0, d.Remove(0, 6)+ "/"));

            //d = d.Remove(10);
            
            d = d + " " + time+":00";
            d = d.Replace("/", "-");

            String numPeople = textBox1.Text;

            //d=d.Insert(0, "'");
            //d = d.Insert(d.Length, "'");


            if (checkRes(d) == false)
            {
                MySQLConnection db = new MySQLConnection();
                db.OpenConn();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO reservation (date,reservation_people,client_name) VALUES (@d,@num,@name)", db.getConnection());
                
                mySqlCommand.Parameters.Add("@d", MySqlDbType.VarChar).Value =d;
                mySqlCommand.Parameters.Add("@num", MySqlDbType.Int16).Value = numPeople;
                mySqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox2.Text;

                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Reservation created");

                }
                else
                {
                    MessageBox.Show("Reservation not created");
                }
                db.CloseConn();
            }


        }

        public bool checkRes(String d)
        {
            MySQLConnection db = new MySQLConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM reservation WHERE date = @date", db.getConnection());
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = d;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)

        {

            if (sender is RadioButton)

            {

                RadioButton radioButton = (RadioButton)sender;

                //Code to use radioButton's properties to do something useful.
                time = radioButton.Text;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
