namespace onlinebookshop.Server.DBFiles
{
    public class Book
    {
        public Guid ID;
        public string Title { get; set; } = null!;
        public string ShortBookDescription { get; set; } = null!;
        public int NumberOfPages  { get; set; }
        public string AuthorName{ get; set; } = null!;
        public string Genre { get; set; } = null!;
        public DateTime PublishDate { get; set; }
    }
}
