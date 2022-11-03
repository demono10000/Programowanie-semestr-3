using Microsoft.AspNetCore.Mvc;
using Pierwszy.services.lab4;

namespace Pierwszy.Controllers.lab4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("pl");
            return lang.GetLanguageName();
        }
    }
}
