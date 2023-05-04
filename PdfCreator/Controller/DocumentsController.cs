using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PdfCreator.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        [Route("[action]/{id}")]
        public IActionResult Download(string id)
        {
            var fs = new FileStream("c:\\temp\\test.docx", FileMode.Open);
            return File(fs, "application/msword", "test.docx");
        }
    }
}
