namespace PdfCreator.Service
{
    public interface IDocumentGenerator
    {
        void CreateDocument(List<string> documentData);
    }
}
