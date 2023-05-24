namespace PdfCreator.Service
{
    public interface IDocumentGenerator
    {
        void CreateDocument(string html, string path);
    }
}
