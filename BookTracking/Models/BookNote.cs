using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracking.Models
{
    public class BookNote
    {
        public int Id { get; set; }

        public string Note { get; set; }

        public int Page { get; set; }

        public DateTime DateAdded { get; set; }

        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
