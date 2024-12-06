namespace BookTracking.Models.UI
{
    /// <summary>
    /// Dto class used to manage review entries in UI
    /// </summary>
    public class ReviewEntry
    {
        public int Id { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }

        public DateTime DateRead { get; set; } = DateTime.Now;
    }
}
