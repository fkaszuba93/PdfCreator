namespace PdfCreator.Service
{
    public class DocumentsService
    {
        private readonly IDocumentGenerator documentGenerator;

        public DocumentsService(IDocumentGenerator documentGenerator)
        {
            this.documentGenerator = documentGenerator;
        }

        public string CreateDocument(string html)
        {
            documentGenerator.CreateDocument(html);
            return "test";
        }
    }
}
