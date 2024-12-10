namespace UrlShortener.Models
{
    public class UrlMapping
    {
        public int Id { get; set; }
        public string OriginalUrl { get; set; }=string.Empty; //ou string?
        public string ShortCode { get; set; } =string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccessCount { get; set; } // pk public int AccessCount { get; set; } = 0;
    }
}
