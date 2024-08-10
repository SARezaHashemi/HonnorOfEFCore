using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HonorOfEFCore.Models;

namespace HonorOfEFCore.Controllers;

public class SarmadiController : Controller
{
    private readonly ILogger<SarmadiController> _logger;
    private AppDbContext _context;

    public SarmadiController(ILogger<SarmadiController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    public IActionResult Scenario(){
        DateTime now = DateTime.Now;
        DateTime ThreeMonthAgo = now.Subtract(TimeSpan.FromDays(90));
        DateTime AYearAgo = now.Subtract(TimeSpan.FromDays(365));

        // You can customize your selecting columns with Select extention method
        var data = _context.Factors.Where(f => f.FactorDate > ThreeMonthAgo)
                                   .GroupBy(f => f.CustomerId)
                                   .Where(g => g.Count()>5 && g.Sum(g => g.getSum()) > 20000000)
                                   .Select(g => g.Key);
        var data2 = _context.Factors.Where(f => f.FactorDate > AYearAgo)
                                    .GroupBy(f => f.CustomerId)
                                    .Where(g => g.Any(f1 => 
                                                        g.Any(f2 => f2.Id != f1.Id &&
                                                        Math.Abs((f1.FactorDate - f2.FactorDate).TotalDays)>3 &&
                                                        g.Sum(f => f.getSum()) > 10000000)
                                                        ))
                                    .Select(g => g.Key);
        var result = data.Union(data2).Distinct().ToList();
                                   
        return View();
    }
}
