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
    public ActionResult Create(string contents, int dimensionsH, int dimensionsW, int dimensionsL, int weight)
    {
      Parcel myParcel = new Parcel(contents, dimensionsH, dimensionsW, dimensionsL, weight);
      string myVolume = myParcel.Volume(dimensionsH, dimensionsW, dimensionsL);
      int myCost = myParcel.CostToShip(myVolume, weight);
      return RedirectToAction("Index");
    }
    
  }
}