namespace Darkstore
{
    public static class SampleData
    {
        public static List<Book> Books { get; } = new List<Book>
    {
        new Book { Id = 1, Title = "The Raven", Author = "Edgar Allan Poe", Language = "English", Year = 1845 },
        
        new Book { Id = 2, Title = "Les fleurs du mal", Author = "Charles Baudelaire", Language = "French", Year = 1957},

        new Book { Id = 3, Title = "Una temporada en el infierno", Author = "Arthur Rimbaud", Language ="Espanol", Year = 1973},

        new Book { Id = 4, Title = "Les poetes maudits", Author = "Paul Verlanie", Language = "French", Year = 1884 }
        // Otros libros de poesía y autores
    };
    }
}

