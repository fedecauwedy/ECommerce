using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cau.Tumidei._5h.ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Cau.Tumidei._5h.ECommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult registrazione()
    {
        return View();
    }
    [HttpPost]
        public IActionResult registrato(Utente u )
    {
        Database db = new Database();
        db.Utenti.Add(u);
        db.SaveChanges();
        return View(u);
    }
      public IActionResult Accedi()
    {
        return View();
    }
    [HttpPost]
    public IActionResult P1 (Utente u)
    {
        Database db = new Database();
        if (u.NomeUtente != null)
        {
            foreach (var item in db.Utenti)
            {
                if (item.NomeUtente == u.NomeUtente && item.Psw == u.Psw)
                {
                    return View("Index");
                }
            }
        }
        return View("Privacy");
    }
    public IActionResult maglie()
    {
        Database db = new Database();
        return View( db.Maglie );
    }
            public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
