using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Forms;

namespace RestaurantManager
{

    class MySQLConnection
    {

        /// <summary>
        /// DataSource : MY-LAPTOP
        /// Initial Catalog: Test
        /// User ID:
        /// Password:
        /// </summary>

        public MySQLConnection() { }

        public static MySqlConnection conn;
        public object SqlNull(int obj)
        {
            if (obj == 0)
            {
                return DBNull.Value;
            }
            else
            {
                return obj;
            }
        }
        public object SqlNull(string obj)
        {
            if (obj == null)
            {
                return DBNull.Value;
            }
            else
            {
                return obj;
            }
        }
        public object SqlNull(DateTime obj)
        {
            if (obj == default(DateTime))
            {
                return DBNull.Value;
            }
            else
            {
                return obj;
            }
        }
        public MySqlConnection getConnection()
        {
            return conn;
        }

        public void OpenConn()
        {
            string SqlCon = "server=98.115.187.178;port=9005;user=root;password=root;database=Restaurant;";
            conn = new MySqlConnection(SqlCon);
            conn.Open();
        }
        public void CloseConn()
        {
            if (conn.State.ToString().ToLower() == "open")
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public MySqlDataReader GetDataReaderValue(string sql, params MySqlParameter[] dic)
        {
            OpenConn();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(dic);
            MySqlDataReader dr = cmd.ExecuteReader();
            CloseConn();
            return dr;
        }
        public DataSet GetDataSetValue(string sql, string tableName, params MySqlParameter[] dic)
        {
            OpenConn();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(dic);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            CloseConn();
            return ds;
        }
        public DataView GetDataViewValue(string sql, string tableName, params MySqlParameter[] dic)
        {
            OpenConn();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(dic);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "temp");
            CloseConn();
            return ds.Tables[0].DefaultView;
        }
        public DataTable GetDataTableValue(string sql, params MySqlParameter[] dic)
        {
            OpenConn();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(dic);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConn();
            return dt;
        }
        public bool ExecuteNonQuery(string sql, params MySqlParameter[] dic)
        {
            try
            {
                OpenConn();
                MySqlCommand cmd;
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddRange(dic);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                CloseConn();
            }
        }
        public int ExecuteNonQueryCount(string sql, params MySqlParameter[] dic)
        {
            OpenConn();
            MySqlCommand cmd;
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(dic);
            int value = cmd.ExecuteNonQuery();
            return value;
        }
        public object ExecuteScalar(string sql, params MySqlParameter[] dic)
        {
            OpenConn();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(dic);
            object value = cmd.ExecuteScalar();
            return value;
        }
        public int SqlServerRecordCount(string sql, params MySqlParameter[] dic)
        {
            OpenConn();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.Parameters.AddRange(dic);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            int RecordCount = 0;
            while (dr.Read())
            {
                RecordCount++;
            }
            CloseConn();
            return RecordCount;
        }
        public bool GetSafeValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            foreach (char ch in value)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }

}