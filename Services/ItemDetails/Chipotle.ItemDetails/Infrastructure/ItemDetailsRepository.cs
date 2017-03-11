using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chipotle.ItemDetails.Models;
using System.Data.Entity;

namespace Chipotle.ItemDetails.Infrastructure
{
    public class ItemDetailsRepository
    {
        public ItemDetailsDb _db;

        public ItemDetailsRepository()
        {
            _db=new ItemDetailsDb();
        }
        public void SaveItemdetails(string itemId,string name)
        {
            var itemDetail = new ItemDetail(itemId, name);
            _db.ItemDetails.Add(itemDetail);
            _db.SaveChanges();
        }

        public ItemDetail GetItemDetails(string itemId)
        {
            var itemDetail = _db.ItemDetails.Single(i => i.ItemId == itemId);
            return itemDetail;
        }
    }
}