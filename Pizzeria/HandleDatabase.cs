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
        static public bool SendToDatabase(string aOrderList, string aComment, int aTotalPrice)
        {
            
            
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.ConnectionString = Properties.Settings.Default.OrderHistoryConnectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = @"INSERT INTO OrderHistory" +
                                       "(SentTo, OrderList, Comment, Price, Date)" +
                                       "VALUES (@SentTo, @OrderList, @Comment, @Price, @Date)";
            sqlCommand.Parameters.Add("@SentTo", SqlDbType.Text).Value = Properties.Settings.Default.EmailTo;
            sqlCommand.Parameters.Add("@OrderList", SqlDbType.Text).Value = aOrderList;
            sqlCommand.Parameters.Add("@Comment", SqlDbType.Text).Value = aComment;
            sqlCommand.Parameters.Add("@Price", SqlDbType.Int).Value = aTotalPrice;
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
