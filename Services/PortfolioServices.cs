using MyPortfolio.Models;

namespace PortfolioApp.Services;

public class PortfolioService
{
    public PortfolioViewModel GetPortfolioData()
    {
        return new PortfolioViewModel
        {
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "GPA Calculator Web App",
                    Description = "A fast, responsive web tool to calculate semester GPA built using .NET and Bootstrap.",
                    TechStack = new List<string> { ".NET", "C#", "Bootstrap", "JavaScript" },
                    GithubUrl = "https://github.com/msalahudin441-wq/GpaCalc.git",
                    LiveUrl = "https://gpacalc.runasp.net/"
                },
                new Project
                {
                    Id = 2,
                    Title="BlogVue Web App",
                    Description = "A modern blog platform built with .NET Core, featuring user authentication(using JWT) and CRUD operations.",
                    TechStack = new List<string> { ".NET Core", "C#", "JavaScript" },
                    GithubUrl = "https://github.com/msalahudin441-wq/BlogVue-WebApp.git",
                    LiveUrl = "https://blogvue-azurewebsites-net-ehe4a0gsc4dhhsfr.eastasia-01.azurewebsites.net/"
                },
                new Project
                {
                  Id=3,
                Title="Portfolio Website",
                Description="A personal Portfolio Website built with .NET core MVC and Boostrap.",
                TechStack=new List<string>{".NET Core MVC","Bootsrap"},
                GithubUrl="https://github.com/msalahudin441-wq/MyPortfolio.git",
                LiveUrl="https://salahudinportfolio.runasp.net/"

                }
            },
            Skills = new List<Skill>
            {
                new Skill { Category = "Backend & Databases", Items = new List<string> { "C#", ".NET Core MVC","WebApi", "SQL", "Database Design" } },
                new Skill { Category = "Frontend & UI", Items = new List<string> { "HTML5", "CSS", "Bootstrap", "JavaScript" } }
            },
            EducationList = new List<Education>
            {
                new Education
                {
                    Degree = "BS in Computer Science",
                    Institution = "University Of Engineering & Technology,Lahore",
                    Period = "2025 - Present",
                    Description = "Focused on software engineering, database architectures, and web application development."
                }
                ,
                 new Education
                {
                    Degree = "Intermediate In Computer Science",
                    Institution = "Government Graduate College , Karor Lal Esan",
                    Period = "2023 - 2025",
                    Description = "Focused on basics of computer science and programming."
                }
            }
        };
    }
}