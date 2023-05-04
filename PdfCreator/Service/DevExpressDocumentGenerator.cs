using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace PdfCreator.Service
{
    public class DevExpressDocumentGenerator : IDocumentGenerator
    {
        private readonly RichEditDocumentServer wordProcessor;
        private readonly Document document;

        public DevExpressDocumentGenerator()
        {
            wordProcessor = new RichEditDocumentServer();
            document = wordProcessor.Document;
        }

        public void CreateDocument(List<string> documentData)
        {
            foreach (string line in documentData)
            {
                document.AppendText(line + "\n\n");
            }

            wordProcessor.SaveDocument("c:\\temp\\test.docx", DocumentFormat.OpenXml);
        }
    }
}
