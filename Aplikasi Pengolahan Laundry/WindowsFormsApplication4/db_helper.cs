using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class db_helper
    {
        public SqlConnection _Connection;

        public bool openConnection()
        {
          if(_Connection != null)
           {
               try
               {
                   if(_Connection.State == System.Data.ConnectionState.Open) _Connection.Close();
                   _Connection.Open();
                   return true;
               }
               catch (Exception ex) 
           {
                   MessageBox.Show(ex.ToString());
                   return false;
                   }

               }
                    return false;
            }
       
         public bool CloseConnection()
        {

            try
            {
              _Connection.Close();
               return true;

            }
            catch (Exception ex)            
            {
                MessageBox.Show(ex.ToString());
                return false;
                
            }
        }

      public SqlConnection InitConnection(string _ConnectionString)
    {
        try
        {
            _Connection = new SqlConnection(_ConnectionString);
            return _Connection;
        }
          catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            return null;
          }
           finally
        {
            if(_Connection != null) _Connection.Close();
        }
      }
    

        public db_helper(string connectionString)
        {
            InitConnection(connectionString);
        }

        public void Execute(string command)
        {
            if(openConnection() == true)
            
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(command, _Connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        public void LoadGrid(DataTable dtValue, DataGridView gv)
        {
            DataTable dty = dtValue;
            gv.DataSource = null;
            gv.Columns.Clear();
            gv.DataSource = dty;
        }

        public DataTable ResultDataTable(string command)
        {
            if (openConnection() == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(command, _Connection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    CloseConnection();
                    return dt;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message + " : ' " + command + " ' ");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void setCombobox(string sql, ComboBox cb, string valueString, string displayString)
        {
            DataTable dtz = new DataTable();
            dtz = ResultDataTable(sql);
            cb.DataSource = dtz;
            cb.DisplayMember = displayString;
            cb.ValueMember = valueString;
        }




    }
}