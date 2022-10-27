using Microsoft.AspNetCore.Mvc;
using Pierwszy.services.lab3;

namespace Pierwszy.Controllers.lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RectangleController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rec = new Rectangle(23, 23);
            return rec.GetArea();
        }
        [HttpGet]
        public int GetSumArea()
        {
            var rec = new Rectangle(4, 4);
            var rec2 = new Rectangle(3, 3);
            return (rec+rec2).GetArea();
        }
    }
}
