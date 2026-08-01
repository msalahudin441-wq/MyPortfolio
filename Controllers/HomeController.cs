using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using PortfolioApp.Services;

namespace PortfolioApp.Controllers;

public class HomeController : Controller
{
    private readonly PortfolioService _portfolioService;

    public HomeController(PortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    public IActionResult Index()
    {
        var data = _portfolioService.GetPortfolioData();
        return View(data);
    }
}