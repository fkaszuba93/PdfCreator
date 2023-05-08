using SelectPdf;

namespace PdfCreator.Service
{
    public class SelectPdfDocumentGenerator : IDocumentGenerator
    {
        public void CreateDocument(string html)
        {
            HtmlToPdf converter = new();

            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

            PdfDocument doc = converter.ConvertHtmlString(html);
            doc.Save("c:\\temp\\test.pdf");
            doc.Close();
        }
    }
}
