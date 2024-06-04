namespace onlinebookshop.Server.DBFiles
{
    public class Author
    {
        public Guid ID;
        public string AuthorName { get; set; } = null!;
        public DateTime EndDateOfWriting { get; set; }
    }
}
