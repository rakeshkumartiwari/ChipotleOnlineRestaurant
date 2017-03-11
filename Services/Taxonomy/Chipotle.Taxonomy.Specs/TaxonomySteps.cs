using Chipotle.Taxonomy.Infrastructure;
using Chipotle.Taxonomy.Models;
using TechTalk.SpecFlow;
using Xunit;

namespace Chipotle.Taxonomy.Specs
{
    [Binding]
    public class TaxonomySteps
    {
        private ItemRepository itemRepository;
        private Item savedItem;
        [Given(@"taxomoy has type for Items")]
        public void GivenTaxomoyHasTypeForItems()
        {
            itemRepository = new ItemRepository();
            itemRepository.SaveItem("21", ItemType.Meal);
            itemRepository.SaveItem("22", ItemType.Meal);
            itemRepository.SaveItem("23", ItemType.Meal);
            itemRepository.SaveItem("24", ItemType.Meal);
        }

        [When(@"type is asked for an Item with (.*)")]
        public void WhenTypeIsAskedForAnItemWith(string itemId)
        {
            savedItem = itemRepository.GetItem(itemId);
        }

        [Then(@"(.*) is returned")]
        public void ThenIsReturned(ItemType type)
        {
            Assert.Equal(type, savedItem.ItemType);
        }



       

       

       

    }
}
