using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductAdd.Gateway
{
  public class Connection
  {
    public SqlConnection con;
    string connection = @"Data Source=PC-301-07\SQLEXPRESS;Initial Catalog=BookInfo;Integrated Security=True";

    public SqlConnection getConnectionActive()
    {
      con = new SqlConnection(connection);
      if (con != null)
      {
        con.Close();
        con.Open();
      }
      else
      {
        con.Open();
      }
      return con;
    }
    public void getConnectionClose()
    {
      con = new SqlConnection(connection);
      if (con != null)
      {
        con.Close();
      }
    }
  }
}