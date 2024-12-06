using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracking.Models
{
    public class Book
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }

        public bool Priority { get; set; }

        public DateTime? DateRead { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsPriority { get; set; } = false;

        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(Genre))]
        public int? GenreId { get; set; }

        public virtual Genre? Genre { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<BookNote> Notes { get; set; } = [];
    }
}
