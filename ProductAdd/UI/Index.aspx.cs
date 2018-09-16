using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductAdd.BIL;
using ProductAdd.Gateway;

namespace ProductAdd.UI
{
  public partial class Index : System.Web.UI.Page
  {
    ProductLogic aLogic = new ProductLogic();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void productAddButton_Click(object sender, EventArgs e)
    {
      ProductAddProperty addProperty = new ProductAddProperty();
      Regex reg = new Regex("[^0-9]");
      if (String.IsNullOrEmpty(productCodeTextbox.Text))
      {
        msgLabel.Text = "<p class='text-danger' >Product Code Empty!</p>";
        return;
      }
       if (String.IsNullOrEmpty(descriptionTextBox.Text))
      {
        msgLabel.Text = "<p class='text-danger' >Description Empty!</p>";
        return;
      }
       if (String.IsNullOrEmpty(quantityTextBox.Text))
       {
         msgLabel.Text = "<p class='text-danger' >Quantity Empty!</p>";
         return;
       }
      else if (productCodeTextbox.Text.Length < 3)
      {
        msgLabel.Text = "<p class='text-danger' >Product Code At Lest 3 Character!</p>";
        return;
      }
      if (reg.IsMatch(quantityTextBox.Text.ToString()))
      {
        msgLabel.Text = "<p class='text-danger' >Quantity  Problem!</p>";
        return;
      }
      else
      {
        addProperty.ProductCode = productCodeTextbox.Text;
        addProperty.Description = descriptionTextBox.Text;
        addProperty.Quantity = Convert.ToInt32(quantityTextBox.Text);
        msgLabel.Text = aLogic.addProcuct(addProperty);
      }

    }
  }
}