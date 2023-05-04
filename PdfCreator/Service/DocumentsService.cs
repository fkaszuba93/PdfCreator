namespace PdfCreator.Service
{
    public class DocumentsService
    {
        private readonly IDocumentGenerator documentGenerator;

        public DocumentsService(IDocumentGenerator documentGenerator)
        {
            this.documentGenerator = documentGenerator;
        }

        public string CreateDocument(List<string> documentData)
        {
            documentGenerator.CreateDocument(documentData);
            return "test";
        }
    }
}
