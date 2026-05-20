namespace BlazorApp1.Models
{
    public class Course
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; }= string.Empty;
        public string Description { get; set; }= string.Empty;
        public decimal Price { get; set; }
        public string CategoryId { get; set;} = string.Empty;
        }
}
