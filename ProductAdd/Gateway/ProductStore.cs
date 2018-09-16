using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProductAdd.Gateway
{
  public class ProductStore
  {
    Connection con = new Connection();

    public bool codeIsExist(string code )
    {
      string query = "SELECT * FROM product_tbl WHERE pcode='" + code + "'";
      SqlCommand cmd = new SqlCommand(query, con.getConnectionActive());
      SqlDataReader reader = cmd.ExecuteReader();
      if (reader.HasRows)
      {
        return true;
      }
      return false;
    }

    public int update(ProductAddProperty addProperty)
    {
      string query = "SELECT * FROM product_tbl WHERE pcode='" + addProperty.ProductCode + "'";
      SqlCommand cmd = new SqlCommand(query, con.getConnectionActive());
      SqlDataReader reader = cmd.ExecuteReader();
      if (reader.HasRows)
      {
        reader.Read();
        int newquantity = (int) reader["pquantity"];
        reader.Close();
        con.getConnectionClose();
        newquantity = newquantity + addProperty.Quantity;
        string newquery = "UPDATE product_tbl SET pquantity = '" + newquantity + "' WHERE pcode='"+addProperty.ProductCode+"'";
        SqlCommand newcmd = new SqlCommand(newquery, con.getConnectionActive());
        int rowCount = newcmd.ExecuteNonQuery();
        con.getConnectionClose();
        return rowCount;

      }
      return 0;
    }
    public int addProcuct(ProductAddProperty addProperty)
    {
      string query = "INSERT INTO product_tbl(pcode,pdescription,pquantity)VALUES('" + addProperty.ProductCode + "','" + addProperty.Description + "','" + addProperty.Quantity + "')";
      SqlCommand cmd = new SqlCommand(query, con.getConnectionActive());
      int rowCount = cmd.ExecuteNonQuery();
      con.getConnectionClose();
      return rowCount;
    }
    public List<ProductAddProperty> productView()
    {
      List<ProductAddProperty> aiInfos = new List<ProductAddProperty>();
      string query = "SELECT * FROM product_tbl";
      SqlCommand cmd = new SqlCommand(query, con.getConnectionActive());
      SqlDataReader reader = cmd.ExecuteReader();

      if (reader.HasRows)
      {
        while (reader.Read())
        {
          ProductAddProperty data = new ProductAddProperty();
          data.ProductCode = reader["pcode"].ToString();
          data.Description = reader["pdescription"].ToString();
          data.eQuantity = reader["pquantity"].ToString();
          aiInfos.Add(data);
        }
      }
      reader.Close();
      con.getConnectionClose();
      return aiInfos;
    }

    public int totalQuantity()
    {
      int sum = 0;
      string query = "SELECT pquantity FROM product_tbl";
      SqlCommand cmd = new SqlCommand(query, con.getConnectionActive());
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        sum  = sum + (int)reader["pquantity"];
      }

      return sum;
    }
  }
}