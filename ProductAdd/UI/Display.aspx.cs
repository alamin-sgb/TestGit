using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductAdd.BIL;
using ProductAdd.Gateway;

namespace ProductAdd.UI
{
  public partial class Display : System.Web.UI.Page
  {
    ProductLogic aLogic = new ProductLogic();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        viewBook();
      }
    }
    public void viewBook()
    {
      int value = 1;
      StringBuilder table = new StringBuilder();
      List<ProductAddProperty> aproduct= aLogic.productView();
      if (aproduct.Count > 0)
      {
        table.Append("<br/><table class='table table-bordered table-hover'>");
        table.Append("<thead class='thead-light'><tr><th>Serial No</th><th>Product Code</th>");
        table.Append("<th>Description</th><th>Quantity</th></tr></thead>");
        foreach (var data in aproduct)
        {
          table.Append("<tbody><tr>");
          table.Append("<td>");
          table.Append(value++);
          table.Append("</td>");
          table.Append("<td>" + data.ProductCode + "</td>");
          table.Append("<td>" + data.Description + "</td>");
          table.Append("<td>" + data.eQuantity + "</td>");
          table.Append("</tr></tbody>");
        }
        table.Append("</table>");
        dataViewall.Controls.Add(new Literal { Text = table.ToString() });
        total.Text = aLogic.totalQuantity();
      }
      else
      {
        dataViewall.Controls.Add(new Literal { Text = "No Data Found".ToString() });
      }
    }
  }
}