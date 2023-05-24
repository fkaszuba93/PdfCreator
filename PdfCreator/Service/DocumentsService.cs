using PdfCreator.Model;
﻿using PdfCreator.Data;

namespace PdfCreator.Service
{
    public class DocumentsService
    {
        private readonly IDocumentGenerator documentGenerator;
        private readonly DocumentContext dbContext;

        public DocumentsService(IDocumentGenerator documentGenerator, DocumentContext dbContext)
        {
            this.documentGenerator = documentGenerator;
            this.dbContext = dbContext;
        }

        public FileStream GetDocumentById(string id)
        {
            var document = dbContext.Documents
                .Where(doc => doc.Id == id)
                .First();

            return new FileStream(document.Path, FileMode.Open);
        }

        public string CreateDocument(string html)
        {
            Document document = new();
            string path = $"obj\\Documents\\{document.Id}.pdf";
            documentGenerator.CreateDocument(html, path);
            document.Path = new FileInfo(path).FullName;

            dbContext.Documents.Add(document);
            dbContext.SaveChanges();

            return document.Id;
        }
    }
}
