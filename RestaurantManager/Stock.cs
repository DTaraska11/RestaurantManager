using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class StockClass : Form
    {
        Boolean local = false;
        private bool m_isdataGridViewBegingEdit = false;
        public DataGridViewTextBoxEditingControl CellEdit = null;
        bool isSearchOrAddIsClick = false;
        int authority;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && (m_isdataGridViewBegingEdit == true || this.dataGridView1.Focused == true))
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        string strcon = "Data Source=.;Initial Catalog=TestDB;Integrated Security=True";
        public StockClass()
        {
            InitializeComponent();
        }
        public StockClass(int authority)
        {
            InitializeComponent();
            this.authority = authority;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            InitialGrid();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "operate";
            button.Text = "Del";
            button.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.AddRange(button);
            comboB_type.SelectedIndex = 0;
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

        private void InitialGrid()
        {
            DataSet ds;

            if (local)
            {

                 ds = GetDataSet("select * from stock");
            }
            else
            {
                 ds = MySQLConnection1.GetDataSetValue("select * from stock", "tb");    
            }
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "tb";
            ColumnOrder();

            style();
          
        }

        private void style()
        {
            //dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left);
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.AllowUserToDeleteRows = false;
          //  dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0099FF");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#fff");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.GridColor = ColorTranslator.FromHtml("#006CB3");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#E7F5FF");
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0099FF");
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#97D5FF");
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E1F3FF");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["itemID"].ReadOnly = true;
            dataGridView1.Columns["type"].ReadOnly = true;
        }

        private void showSafe()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToDouble(dataGridView1["quantity", i].Value) < Convert.ToDouble(dataGridView1["itemSafeStock", i].Value))
                {
                    dataGridView1["quantity", i].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btn_safe_Click(object sender, EventArgs e)
        {
            showSafe();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql;
            string type;
            if (!IsNumberic(txt_id.Text)&& txt_id.Text!="")
            {
                MessageBox.Show("ID must be a number");
            }
            else
            {
                if (comboB_type.Text == "All")
                {
                    type = "";
                }
                else type = comboB_type.Text;
                if (txt_id.Text == "")
                {
                    sql = "select * from stock where itemID like '%" + txt_id.Text + "%' and itemName like '%" + txt_name.Text + "%' and type like '%" + type + "%'";

                }
                
                else sql = "select * from stock where itemID = '" + txt_id.Text + "' and itemName like '%" + txt_name.Text + "%' and type like '%" + type + "%'";
                if (local)
                {

                    DataSet ds = GetDataSet(sql);
                   
                    this.dataGridView1.DataSource = ds;
                    this.dataGridView1.DataMember = "tb";
                    ColumnOrder();
                }
                else
                {
                    DataSet ds = MySQLConnection1.GetDataSetValue(sql,"tb");
                  
                    this.dataGridView1.DataSource = ds;
                    this.dataGridView1.DataMember = "tb";
                    ColumnOrder();

                }


              
            }
            isSearchOrAddIsClick = true;
         
        }
        private void ColumnOrder()
        {
            this.dataGridView1.Columns["itemID"].DisplayIndex = 0;
            this.dataGridView1.Columns["itemName"].DisplayIndex = 1;
            this.dataGridView1.Columns["itemSafeStock"].DisplayIndex = 2;
            this.dataGridView1.Columns["quantity"].DisplayIndex = 3;
            this.dataGridView1.Columns["type"].DisplayIndex = 4;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void updateData(int id,string name, int safe, int qty)
        {
            try
            {
               
                string UpdateSql = "update stock" +
                    " set itemName = '" + name + "'," +
                    "itemSafeStock = '" + safe + "'," +
                    "quantity = '" + qty + "'" +
                    "where itemID = '" + id+ "'";
                if (local)
                {
                    SqlConnection sqlcon = new SqlConnection(strcon);
                    sqlcon.Open();
                    SqlCommand com = new SqlCommand(UpdateSql, sqlcon);
                    com.ExecuteNonQuery();
                    SqlDataAdapter ada = new SqlDataAdapter("select * from stock", sqlcon);
                    DataSet ds = new DataSet();
                    ada.Fill(ds, "stock");
                    sqlcon.Close();
                }
                else
                {
                    MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
                    MySqlCon.Open();
                    MySqlCommand com = new MySqlCommand(UpdateSql, MySqlCon);
                    com.ExecuteNonQuery();
                    MySqlDataAdapter ada = new MySqlDataAdapter("select * from stock", MySqlCon);
                    DataSet ds = new DataSet();
                    ada.Fill(ds, "stock");
                    MySQLConnection1.CloseConn();
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            comboB_type.SelectedIndex = 0;
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            m_isdataGridViewBegingEdit = true;
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            insertData();
           
            isSearchOrAddIsClick = true;
        }

        private void insertData()
        {
            try
            {
                if (!IsNumberic(txt_safe.Text))
                {
                    MessageBox.Show("Safe stock must be a number");
                    return;
                }
                 if (!IsNumberic(txt_qty.Text))
                {
                    MessageBox.Show("Qty must be be a number");
                    return;
                }
                if (comboB_type1.Text == "")
                {
                    MessageBox.Show("Must select the type of item");
                    return;
                }
                else
                {
                    string InsertSql = "insert into stock(itemName,itemSafeStock,quantity,type) " +
                        "values ('" + txt_name1.Text + "'" +
                        ",'" + txt_safe.Text + "'" +
                        ",'" + txt_qty.Text + "'" +
                        ",'" + comboB_type1.Text + "')";

                    if (local)
                    {
                        SqlConnection sqlcon = new SqlConnection(strcon);
                        sqlcon.Open();
                        SqlCommand com = new SqlCommand(InsertSql, sqlcon);
                        com.ExecuteNonQuery();
                        SqlDataAdapter ada = new SqlDataAdapter("select * from stock", sqlcon);
                        DataSet ds = new DataSet();
                        ada.Fill(ds, "stock");
                        sqlcon.Close();
                    }
                    else
                    {
                        MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
                        MySqlCon.Open();
                        MySqlCommand com = new MySqlCommand(InsertSql, MySqlCon);
                        com.ExecuteNonQuery();
                        MySqlDataAdapter ada = new MySqlDataAdapter("select * from stock", MySqlCon);
                        DataSet ds = new DataSet();
                        ada.Fill(ds, "stock");
                        MySQLConnection1.CloseConn();
                    }
                    MessageBox.Show("successful");
                    txt_name1.Text = "";
                    txt_safe.Text = "";
                    txt_qty.Text = "";
                    comboB_type1.Text = "";
                    InitialGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            m_isdataGridViewBegingEdit = false;
            string name;
            int safe;
            int qty;
            int id;
            if (dataGridView1.Rows.Count > 0)
            {
                if (!IsNumberic(this.dataGridView1.Rows[e.RowIndex].Cells["itemID"].Value.ToString()))
                {
                    MessageBox.Show("ID must be a number");
                }
                else if (!IsNumberic(this.dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString()))
                {
                    MessageBox.Show("qty must be a number");
                }
                else if (!IsNumberic(this.dataGridView1.Rows[e.RowIndex].Cells["itemSafeStock"].Value.ToString()))
                {
                    MessageBox.Show("safe stock must be a number");
                }
                else
                {
                    id = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
                    name = this.dataGridView1.Rows[e.RowIndex].Cells["itemName"].Value.ToString();
                    safe = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells["itemSafeStock"].Value.ToString());
                    qty = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
                    updateData(id, name, safe, qty);
                    
                    if (Convert.ToDouble(dataGridView1["itemSafeStock", e.RowIndex].Value) > Convert.ToDouble(dataGridView1["quantity", e.RowIndex].Value))
                    {
                        dataGridView1["quantity", e.RowIndex].Style.ForeColor = Color.Red;
                    }
                    else dataGridView1["quantity", e.RowIndex].Style.ForeColor = Color.Black;

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RIndex = e.RowIndex;
            int CIndex = e.ColumnIndex;
            if (!isSearchOrAddIsClick)
            {
                if (CIndex == 5)  //this because the index of button will change after clicking search button
                {


                    DialogResult dr = MessageBox.Show("Do you want to delete this row? ", "warning", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        int id = int.Parse(this.dataGridView1.Rows[RIndex].Cells[0].Value.ToString());
                        deleteData(id);
                        InitialGrid();
            
                    
                    }
                }
              
            }
            else
            {
                if (CIndex == 0)
                {


                    DialogResult dr = MessageBox.Show("Do you want to delete this row? ", "warning", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        int id = int.Parse(this.dataGridView1.Rows[RIndex].Cells[1].Value.ToString());
                        deleteData(id);
                        InitialGrid();
                  
                    }
                }
            }
           
        }
        private void deleteData(int id)
        {
            try
            {

                string DeleteSql = "Delete from stock where itemID = '" + id + "'";
                if (local)
                {
                    SqlConnection sqlcon = new SqlConnection(strcon);
                    sqlcon.Open();
                    SqlCommand com = new SqlCommand(DeleteSql, sqlcon);
                    com.ExecuteNonQuery();
                    SqlDataAdapter ada = new SqlDataAdapter("select * from stock", sqlcon);
                    DataSet ds = new DataSet();
                    ada.Fill(ds, "stock");
                    sqlcon.Close();
                }
                else
                {
                    MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
                    MySqlCon.Open();
                    MySqlCommand com = new MySqlCommand(DeleteSql, MySqlCon);
                    com.ExecuteNonQuery();
                    MySqlDataAdapter ada = new MySqlDataAdapter("select * from stock", MySqlCon);
                    DataSet ds = new DataSet();
                    ada.Fill(ds, "stock");
                    MySQLConnection1.CloseConn();
                }
                MySqlConnection MySqlCon1 = new MySqlConnection(MySQLConnection1.SqlCon);
                MySqlCon1.Open();
                MySqlCommand com1 = new MySqlCommand("ALTER TABLE stock AUTO_INCREMENT = 1;", MySqlCon1);
                com1.ExecuteNonQuery();
                MySqlDataAdapter ada1 = new MySqlDataAdapter("select * from stock", MySqlCon1);
                DataSet ds1 = new DataSet();
                ada1.Fill(ds1, "stock");
                MySQLConnection1.CloseConn();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool IsNumberic(string oText)
        {
            try
            {
                Decimal Number = Convert.ToDecimal(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {

                if ((dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["itemSafeStock"].Index) || (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["quantity"].Index))
                {
                    if (this.dataGridView1.CurrentCellAddress.X == i)
                    {
                        {
                            if (this.dataGridView1.CurrentCellAddress.X == i)
                            {
                                CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
                                CellEdit.SelectAll();
                                CellEdit.KeyPress += Cells_KeyPress; 
                            }
                        }
                    }
                }
                else 
                {
                    CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
                    CellEdit.SelectAll();
                    CellEdit.KeyPress -= Cells_KeyPress; 
                }
            }

        }
        private void Cells_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                      e.Handled = true;
           
        }

        private void StockClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            //User user = new User(authority);
            //var nextForm = new MainPage(user);
            //nextForm.Show();
        }
    }
}
