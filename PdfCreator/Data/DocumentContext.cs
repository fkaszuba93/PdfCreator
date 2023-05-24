using Microsoft.EntityFrameworkCore;
using PdfCreator.Model;

namespace PdfCreator.Data
{
    public class DocumentContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

        public DocumentContext(DbContextOptions options) : base(options)
        {
        }
    }
}
