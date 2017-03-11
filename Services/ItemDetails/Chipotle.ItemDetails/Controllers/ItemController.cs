using System.Web.Http;
using Chipotle.ItemDetails.Infrastructure;
using Chipotle.ItemDetails.Models;

namespace Chipotle.ItemDetails.Controllers
{
    public class ItemController : ApiController
    {
        public ItemDetail Get()
        {
            var repository = new ItemDetailsRepository();
            repository.SaveItemdetails("1","Baritto");
            var savedItemDetails = repository.GetItemDetails("1");
            return savedItemDetails;
        }

        
    }
}
