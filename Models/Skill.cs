namespace MyPortfolio.Models
{
    public class Skill
    {
        public string Category { get; set; } = string.Empty; // e.g., "Backend", "UI/UX"
        public List<string> Items { get; set; } = new();
    }
}
