using ItemService.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ItemService.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        [HttpPost]
        public Item Post(Item _requestData)
        {
            _requestData.Quality--;
            _requestData.SellIn--;

            return _requestData;
        }
    }
}
