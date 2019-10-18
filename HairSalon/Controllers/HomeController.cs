using Microsoft.AspNetCore.Mvc;
using Salon.Models;

namespace Salon.Controllers
{
  public class HomeController : Controller
  {
    private readonly SalonContext _db;

    public HomeController(SalonContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {

      return View();
    }
  }
}