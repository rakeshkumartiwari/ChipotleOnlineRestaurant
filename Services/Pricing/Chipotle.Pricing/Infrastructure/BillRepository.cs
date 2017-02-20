using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public class BillRepository
    {
        private PricingDb db;

        public BillRepository()
        {
            db = new PricingDb();
        }

        public void SaveBill(string billId, List<LineItem> lineItems)
        {
            var bill = new Bill(billId, lineItems);
            db.Bills.Add(bill);
            db.SaveChanges();
        }

        public Bill GetBill(string billId)
        {
            var bills = db.Bills.Include(l => l.LineItems).Single(b => b.BillId == billId);
            return bills;
        }

        
    }
}