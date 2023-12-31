using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class EntriesController : Controller
  {
    [HttpGet("/inventory")]
    public ActionResult Index()
    {
      List<Entry> allEntries = Entry.GetAll();
      return View(allEntries);
    }

    [HttpGet("/inventory/newentry")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/inventory")]
    public ActionResult Create(string vehicleType, int vehicleYear, string vehicleMake, string vehicleModel)
    {
      Entry anEntry = new Entry(vehicleType, vehicleYear, vehicleMake, vehicleModel);
      return RedirectToAction("Index");
    }

  }
}