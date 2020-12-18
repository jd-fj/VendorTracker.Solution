using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}