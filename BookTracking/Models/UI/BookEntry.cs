namespace BookTracking.Models.UI
{
    /// <summary>
    /// Dto class used to manage book entries in UI
    /// </summary>
    public class BookEntry
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int? AuthorId { get; set; }

        public string Author { get; set; }

        public bool IsPriority { get; set; } = false;

        public int? GenreId { get; set; }

        public string Review { get; set; } = string.Empty;

        public int Rating { get; set; }

        public DateTime? DateRead { get; set; }
    }
}
