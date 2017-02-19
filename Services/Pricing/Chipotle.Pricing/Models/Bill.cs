using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Chipotle.Pricing.Models
{
   public class Bill
    {
       public Bill(string billId,List<LineItem> lineItems )
       {
           this.BillId = billId;
           this.LineItems = lineItems;
       }

       public int Id { get; set; }
       public string BillId { get; set; }
       public List<LineItem> LineItems { get; set; }

       public Bill()
       {
           
       }
    }
}