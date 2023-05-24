using PdfCreator.Model;

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
            Document document = new();
            string path = $"obj\\Documents\\{document.Id}.pdf";
            documentGenerator.CreateDocument(html, path);
            document.Path = new FileInfo(path).FullName;
            return document.Id;
        }
    }
}
