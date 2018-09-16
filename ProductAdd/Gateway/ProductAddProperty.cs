using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAdd.Gateway
{
  public class ProductAddProperty
  {
    public string ProductCode { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string eQuantity { get; set; }
  }
}