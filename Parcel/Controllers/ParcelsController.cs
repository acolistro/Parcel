using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/Parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/Parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/Parcels")]
    public ActionResult Create(string contents, string dimensions, int weight)
    {
      Parcel myParcel = new Parcel(makeModel, price, miles);
      return RedirectToAction("Index");
    }
    
  }
}