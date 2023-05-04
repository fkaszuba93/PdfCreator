using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PdfCreator.Service;

namespace PdfCreator.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly DocumentsService documentsService;

        public DocumentsController(DocumentsService documentsService)
        {
            this.documentsService = documentsService;
        }

        [Route("[action]/{id}")]
        public IActionResult Download(string id)
        {
            var fs = new FileStream("c:\\temp\\test.docx", FileMode.Open);
            return File(fs, "application/msword", "test.docx");
        }

        [HttpPost]
        [Route("[action]")]
        public string Create([FromBody] List<string> documentData)
        {
            return documentsService.CreateDocument(documentData);
        }
    }
}
