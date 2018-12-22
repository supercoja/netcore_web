using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hi ", "Working" };
        }
    }
}
