using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracking.Models
{
    public class Author
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public virtual ICollection<Book> Books { get; set; } = [];

        [NotMapped]
        public string DisplayName => $"{FirstName} {LastName}";
    }
}
