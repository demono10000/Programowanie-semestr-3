using Microsoft.AspNetCore.Mvc;
using Pierwszy.services.lab5;

namespace Pierwszy.Controllers.lab5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMetod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}
