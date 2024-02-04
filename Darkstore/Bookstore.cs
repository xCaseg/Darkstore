namespace Darkstore
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Year { get; set; }
        // Otros campos relevantes
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Otros campos relevantes
    }
}
