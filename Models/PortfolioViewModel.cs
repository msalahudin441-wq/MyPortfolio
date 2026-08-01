namespace MyPortfolio.Models
{
    public class PortfolioViewModel
    {
        public List<Project> Projects { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Education> EducationList { get; set; } = new();
    }
}
