using System.Collections.Generic;
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
        public SubmissionModel Post([FromBody]SubmissionModel data)
        {
            SubmissionModel model = new SubmissionModel();

            return data;
        }
    }
}
