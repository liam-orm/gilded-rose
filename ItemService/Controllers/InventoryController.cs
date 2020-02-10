using ItemService.Models;
using Microsoft.AspNetCore.Mvc;
using ItemService.Extensions;

namespace ItemService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        [HttpPost]
        public Item Post(Item _requestData)
        {
            _requestData = IsItemValid(_requestData);
            if (_requestData.ItemIsValid)
            {
                _requestData = _requestData
                    .DoesQualityDegradate()
                    .IsQualityValid()
                    .CalculateSellIn();
            }

            return _requestData;
        }

        private Item IsItemValid(Item _item)
        {
            string itemName = _item.ItemName.ToLower();

            if (itemName == "aged brie" |
                itemName == "normal item" |
                itemName == "conjured" |
                itemName == "sulfuras" |
                itemName == "backstage passes")
            {
                _item.ItemIsValid = true;
            }
            return _item;
        }
    }
}
