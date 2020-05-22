using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> orders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", orders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderName, string description, int quantity, decimal price, string date)
    {
      string[] yearList = { "", "", "", "" };
      string[] monthList = { "", "" };
      string[] dayList = { "", "" };
      for (int i = 0; i < 10; i++)
      {
        if (i < 4)
        {
          yearList[i] = date[i].ToString();
        }
        else if (i == 5)
        {
          monthList[0] = date[i].ToString();
          monthList[1] = date[i + 1].ToString();
        }
        else if (i == 8)
        {
          dayList[0] = date[i].ToString();
          dayList[1] = date[i + 1].ToString();
        }
      }
      string year = string.Join("", yearList);
      string month = string.Join("", monthList);
      string day = string.Join("", dayList);

      DateTime newDate = new DateTime();

      int number;
      bool success = Int32.TryParse(year, out number);

      if (success)
      {
        newDate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
      }
      else
      {
        newDate = new DateTime(1969, 05, 24);
      }

      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = null;
      if (price != 0.00m)
      {
        newOrder = new Order(orderName, description, quantity, price, newDate);
      }
      else
      {
        newOrder = new Order(orderName, description, quantity, newDate);
      }

      foundVendor.AddOrder(newOrder);
      List<Order> orders = foundVendor.Orders;
      model.Add("orders", orders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}