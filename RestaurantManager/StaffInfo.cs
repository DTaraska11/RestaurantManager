using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace RestaurantManager
{

    public partial class StaffInfo : Form
    {
        string strcon = "Data Source=.;Initial Catalog=TestDB;Integrated Security=True";

        Boolean insert = true;
        Boolean add = true;
        Boolean local = false;
        int authority;
        
        // string strcon = "server=192.168.146.128;user=root;password=root;database=Restaurant;";
        public StaffInfo()
        {
            InitializeComponent();
        }
        public StaffInfo(int author)
        {
            InitializeComponent();
            authority = author;
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
   
            treeView1.ExpandAll();
            InitTree(this.treeView1.Nodes, "0");
            treeView1.ExpandAll();
            toolStrip_save.Enabled = false;
            toolStripButton2.Enabled = false;
            MySQLConnection1.OpenConn();
        }
        private DataSet GetDataSet(string strsql)
        {
            SqlConnection con = new SqlConnection(strcon);
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(strsql, con);
                DA.Fill(ds, "tb");
            }
            catch (SqlException E)
            {
                throw new Exception(E.Message);
            }
            con.Close();
            return ds;
        }
        private void InitTree(TreeNodeCollection Nds, string parentId)
        {
           
          
            
            DataView dv = new DataView();
            TreeNode tmpNd;
            string intId;
            if (local)
            {

                DataSet ds = GetDataSet("select * from staff_info");
                dv.Table = ds.Tables[0];
            }
            else
            {
                DataTable dt = MySQLConnection1.GetDataTableValue("select * from staff_info");
                dt.TableName = "staff_info";
                dv.Table = dt;
            }
            
            dv.RowFilter = "parent_id='" + parentId + "'";
            foreach (DataRowView drv in dv)
            {
                tmpNd = new TreeNode();
                tmpNd.Tag = drv["id"].ToString();       
                tmpNd.Text = drv["last_name"].ToString();
                if (drv["parent_id"].ToString() == "1")  //10 means admin
                {
                    tmpNd.ImageIndex = tmpNd.SelectedImageIndex = 0;
                }
                else
                tmpNd.ImageIndex = tmpNd.SelectedImageIndex = 1;
                Nds.Add(tmpNd);
                intId = drv["parent_id"].ToString();
                InitTree(tmpNd.Nodes, tmpNd.Tag.ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            if (e.Action == TreeViewAction.ByMouse)
            {
                DataView dv = new DataView();
                if (local)
                {

                    DataSet ds = GetDataSet("select * from staff_info where id = '" + e.Node.Tag + "'");
                    dv.Table = ds.Tables[0];
                }
                else
                {
                    DataTable dt = MySQLConnection1.GetDataTableValue("select * from staff_info where id = '" + e.Node.Tag + "'");
                    dt.TableName = "staff_info";
                    dv.Table = dt;
                }
              
               
                DataRowView drv = dv[0];
                if (e.Node.Parent != null)
                {
                    txt_name.Text = drv["last_name"].ToString();
                    if (drv["gender"].ToString() == "Male") comBox_gender.SelectedIndex = 0;
                    else comBox_gender.SelectedIndex = 1;
                    txt_SSN.Text = drv["ssn"].ToString();
                    if (drv["parent_id"].ToString() == "1") cmb_position.SelectedIndex = 0;
                    if (drv["parent_id"].ToString() == "2") cmb_position.SelectedIndex = 1;
                    if (drv["parent_id"].ToString() == "3") cmb_position.SelectedIndex = 2;
                    if (drv["parent_id"].ToString() == "4") cmb_position.SelectedIndex = 3;
                    txt_Phone.Text = drv["phone"].ToString();
                    txt_Address.Text = drv["address_id"].ToString();
                    if (!drv["birthday"].Equals(System.DBNull.Value))
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(drv["Birthday"]);
                    }
                    else dateTimePicker1.Value = System.DateTime.Today;


                    txt_Email.Text = drv["email"].ToString();
                    toolStripButton2.Enabled = true;
                    btn_del.Enabled = true;
                }
                else
                { 
                    toolStripButton2.Enabled = false;
                    btn_del.Enabled = false;
                }
                
              
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            lab_position.Visible = true;
            cmb_position.Visible = true;
            treeView1.Enabled = false;
            btn_add.Enabled = false;
            cmb_position.Enabled = true;
            btn_finished.Enabled = true;
            //clear txtbox
            txt_name.Text = "";
            txt_SSN.Text = "";
            txt_Phone.Text = "";
            txt_Address.Text = "";
        //    txt_Birthday.Text = "";
            txt_Email.Text = "";
            //can edit
            comBox_gender.DropDownStyle = ComboBoxStyle.DropDown;
            txt_name.ReadOnly = false;
            txt_SSN.ReadOnly = false;
            txt_Phone.ReadOnly = false;
            txt_Address.ReadOnly = false;
            txt_Email.ReadOnly = false;
            insert = true;
        }

        private void btn_finished_Click(object sender, EventArgs e)
        {
           
          
        }

       

        private void insertData()
        {
            int parentID = 0;
            if (cmb_position.SelectedIndex == 0) parentID = 1;
            if (cmb_position.SelectedIndex == 1) parentID = 2;
            if (cmb_position.SelectedIndex == 2) parentID = 3;
            if (cmb_position.SelectedIndex == 3) parentID = 4;
            if (!IsEmail(txt_Email.Text))
            {
                MessageBox.Show("the email address is invalid");

            }
            else
            {
                string InsertSql = "insert into staff_info(last_name,address_id,phone,parent_id,gender,birthday,ssn,email) " +
                    "values ('" + txt_name.Text + "','" + txt_Address.Text + "','" + txt_Phone.Text + "','" + parentID + "','" + comBox_gender.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm") + "','" + txt_SSN.Text + "','" + txt_Email.Text + "')";

                try
                {
                    if (local)
                    {
                        SqlConnection sqlcon = new SqlConnection(strcon);
                        sqlcon.Open();
                        SqlCommand com = new SqlCommand(InsertSql, sqlcon);
                        com.ExecuteNonQuery();
                        SqlDataAdapter ada = new SqlDataAdapter("select * from staff_info", sqlcon);
                        DataSet ds = new DataSet();
                        ada.Fill(ds, "staff_info");
                        sqlcon.Close();
                    }
                    else
                    {
                        MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
                        MySqlCon.Open();
                        MySQLConnection1.OpenConn();
                        MySqlCommand com = new MySqlCommand(InsertSql, MySqlCon);
                        com.ExecuteNonQuery();
                        MySqlDataAdapter ada = new MySqlDataAdapter("select * from staff_info", MySqlCon);
                        DataSet ds = new DataSet();
                        ada.Fill(ds, "staff_info");
                        MySQLConnection1.CloseConn();
                    }
                    MessageBox.Show("successful");
                    treeView1.Nodes.Clear();
                    InitTree(this.treeView1.Nodes, "0");
                    treeView1.ExpandAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                toolStripButton1.Text = "Add";
                toolStripButton1.Image = imageList1.Images[2];
                toolStripButton1.Enabled = true;
                initial();
            }
        }

        private void updateData()
        {
            int parentID = 0;
            if (cmb_position.SelectedIndex == 0) parentID = 1;
            if (cmb_position.SelectedIndex == 1) parentID = 2;
            if (cmb_position.SelectedIndex == 2) parentID = 3;
            if (cmb_position.SelectedIndex == 3) parentID = 4;
            if (!IsEmail(txt_Email.Text))
            {
                MessageBox.Show("the email address is invalid");
                return;
            }
            else
            {
                string UpdateSql = "update staff_info" +
                       " set last_name = '" + txt_name.Text + "'," +
                       "address_id = '" + txt_Address.Text + "'," +
                       "phone = '" + txt_Phone.Text + "'," +
                       "parent_id = '" + parentID + "'," +
                       "gender = '" + comBox_gender.Text + "'," +
                       "birthday = '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm") + "'," +
                       "ssn = '" + txt_SSN.Text + "'," +
                       "email = '" + txt_Email.Text + "' " +
                       "where id = '" + treeView1.SelectedNode.Tag + "'";


                try
                {
                    if (local)
                    {
                        SqlConnection sqlcon = new SqlConnection(strcon);
                        sqlcon.Open();
                        SqlCommand com = new SqlCommand(UpdateSql, sqlcon);
                        com.ExecuteNonQuery();
                        SqlDataAdapter ada = new SqlDataAdapter("select * from staff_info", sqlcon);
                        DataSet ds = new DataSet();
                        ada.Fill(ds, "staff_info");
                        sqlcon.Close();
                    }
                    else
                    {
                        MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
                        MySqlCon.Open();
                        MySqlCommand com = new MySqlCommand(UpdateSql, MySqlCon);
                        com.ExecuteNonQuery();
                        MySqlDataAdapter ada = new MySqlDataAdapter("select * from staff_info", MySqlCon);
                        DataSet ds = new DataSet();
                        ada.Fill(ds, "staff_info");
                        MySQLConnection1.CloseConn();
                    }

                    MessageBox.Show("successful");
                    treeView1.Nodes.Clear();
                    InitTree(this.treeView1.Nodes, "0");
                    treeView1.ExpandAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                toolStripButton1.Text = "Add";
                toolStripButton1.Image = imageList1.Images[2];
                toolStripButton1.Enabled = true;
               
                initial();
            }
            }
        private void deleteData()
        {
            try
            {
                string DeleteSql = "Delete from staff_info where id = '" + treeView1.SelectedNode.Tag + "'";
                if (local)
                {
                    SqlConnection sqlcon = new SqlConnection(strcon);
                    sqlcon.Open();
                    SqlCommand com = new SqlCommand(DeleteSql, sqlcon);
                    com.ExecuteNonQuery();
                    SqlDataAdapter ada = new SqlDataAdapter("select * from staff_info", sqlcon);
                    DataSet ds = new DataSet();
                    ada.Fill(ds, "staff_info");
                    sqlcon.Close();
                }
                else
                {
                    MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
                    MySqlCon.Open();
                    MySqlCommand com = new MySqlCommand(DeleteSql, MySqlCon);
                    com.ExecuteNonQuery();
                    MySqlDataAdapter ada = new MySqlDataAdapter("select * from staff_info", MySqlCon);
                    DataSet ds = new DataSet();
                    ada.Fill(ds, "staff_info");
                    MySQLConnection1.CloseConn();
                }               
                treeView1.Nodes.Clear();
                InitTree(this.treeView1.Nodes, "0");
                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete "+treeView1.SelectedNode.Text, "warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                deleteData();
                initial();
            }
        }



        private void toolStrip_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_SSN.Text == ""|| txt_Phone.Text == "" ||txt_Address.Text == ""||comBox_gender.Text == ""||cmb_position.Text=="")
            {
                MessageBox.Show("you can leave blanks before submit");
                return;
            }
            if (insert)
            {
                insertData();
            }
            else if (!insert)
            {
                updateData();
            }
            toolStripButton2.Enabled = true;
            btn_del.Enabled = true;
        }

        void initial()
        {
            toolStrip_save.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton1.Enabled = true;
            treeView1.Enabled = true;
           // btn_add.Enabled = true;
            cmb_position.Enabled = false;
            btn_finished.Enabled = false;
            //clear txtbox
            txt_name.Text = "";
            txt_SSN.Text = "";
            txt_Phone.Text = "";
            txt_Address.Text = "";
            //    txt_Birthday.Text = "";
            txt_Email.Text = "";
            //can edit
            comBox_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_name.ReadOnly = true;
            txt_SSN.ReadOnly = true;
            txt_Phone.ReadOnly = true;
            txt_Address.ReadOnly = true;
            txt_Email.ReadOnly = true;
            cmb_position.SelectedIndex = 0;
            dateTimePicker1.Enabled = false;
        }


        void canEdit()
        {
            treeView1.Enabled = false;
            btn_add.Enabled = false;
            cmb_position.Enabled = true;
            btn_finished.Enabled = true;
            //clear txtbox
            txt_name.Text = "";
            txt_SSN.Text = "";
            txt_Phone.Text = "";
            txt_Address.Text = "";
            txt_Email.Text = "";
            //can edit
            comBox_gender.DropDownStyle = ComboBoxStyle.DropDown;
            txt_name.ReadOnly = false;
            txt_SSN.ReadOnly = false;
            txt_Phone.ReadOnly = false;
            txt_Address.ReadOnly = false;
            txt_Email.ReadOnly = false;
            toolStripButton2.Enabled = false;
            toolStrip_save.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            if (add)
            {
                canEdit();
                insert = true;
                toolStripButton1.Text = "cancle";
                toolStripButton1.Image = imageList1.Images[3];
                add = false;
                btn_del.Enabled = false;
            }
            else
            {
                toolStripButton1.Text = "Add";
                toolStripButton1.Image = imageList1.Images[2];
                add = true;
                btn_del.Enabled = true;
                initial();
            }
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            insert = false;
            toolStripButton2.Enabled = false;
            treeView1.Enabled = false;
            comBox_gender.DropDownStyle = ComboBoxStyle.DropDown;
            txt_name.ReadOnly = false;
            txt_SSN.ReadOnly = false;
            txt_Phone.ReadOnly = false;
            txt_Address.ReadOnly = false;
            txt_Email.ReadOnly = false;
            cmb_position.Enabled = true;
            btn_finished.Enabled = true;
            dateTimePicker1.Enabled = true;
            btn_add.Enabled = true;
            toolStrip_save.Enabled = true;
            toolStripButton1.Enabled = false;
            btn_del.Enabled = false;

        }

        public static Boolean IsEmail(string str)
        {
            string res = string.Empty;
            string expression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(str, expression, RegexOptions.Compiled))
            {
                return true;
            }
            return false;
        }

        private void StaffInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //User user = new User(authority);
            //var nextForm = new MainPage(user);
            //nextForm.Show();
        }
    }
    

}
