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
            var fs = documentsService.GetDocumentById(id);
            return File(fs, "application/pdf", "Dokument.pdf");
        }

        [HttpPost]
        [Route("[action]")]
        public string Create([FromBody] string html)
        {
            return documentsService.CreateDocument(html);
        }
    }
}
