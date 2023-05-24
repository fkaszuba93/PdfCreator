namespace PdfCreator.Model
{
    public class Document
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public DateTime CreateDate { get; set; }

        public Document()
        {
            Id = Guid.NewGuid().ToString();
            CreateDate = DateTime.Now;
            Path = "";
        }
    }
}
