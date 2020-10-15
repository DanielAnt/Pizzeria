using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Pizzeria
{
    class HandleDatabase
    {
        static public bool send_to_database(string order_list, string comment, int total_price)
        {
            
            
            SqlConnection sql_connection = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();
            sql_connection.ConnectionString = Properties.Settings.Default.OrderHistoryConnectionString;
            sql_command.Connection = sql_connection;
            sql_command.CommandText = @"INSERT INTO OrderHistory" +
                                       "(SentTo, OrderList, Comment, Price, Date)" +
                                       "VALUES (@SentTo, @OrderList, @Comment, @Price, @Date)";
            sql_command.Parameters.Add("@SentTo", SqlDbType.Text).Value = Properties.Settings.Default.EmailTo;
            sql_command.Parameters.Add("@OrderList", SqlDbType.Text).Value = order_list;
            sql_command.Parameters.Add("@Comment", SqlDbType.Text).Value = comment;
            sql_command.Parameters.Add("@Price", SqlDbType.Int).Value = total_price;
            sql_command.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
            try
            {
                sql_connection.Open();
                sql_command.ExecuteNonQuery();
                sql_connection.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
