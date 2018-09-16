using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductAdd.Gateway;

namespace ProductAdd.BIL
{
  public class ProductLogic
  {
    ProductStore aStore = new ProductStore();
    public bool codeIsExist(string code)
    {
      return aStore.codeIsExist(code);
    }
    public string addProcuct(ProductAddProperty addProperty )
    {
      if (addProperty.Quantity>0)
      {
        if (codeIsExist(addProperty.ProductCode))
        {
          int update = aStore.update(addProperty);
          if (update > 0)
          {
            return "<p class='text-success'>Product Update Successfully</p>";
          }
          else
          {
            return "<p class='text-danger'>Problem Something</p>";
          }
        }
        int rowCount = aStore.addProcuct(addProperty);
        if (rowCount>0)
        {
          return "<p class='text-success'>Product Add Successfully</p>";
        }
        else
        {
          return "<p class='text-danger'>Fail to Product Add</p>";
        }
      }
      return "<p class='text-warning'>Positive Number</p>";
    }
    public List<ProductAddProperty> productView()
    {
      return aStore.productView();
    }

    public string totalQuantity()
    {
      int a = aStore.totalQuantity();
      return a.ToString();
    }
  }
}