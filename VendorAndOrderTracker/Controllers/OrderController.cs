using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpPost("/orders")]
    public ActionResult Create(string orderName)
    {
      Order myOrder = new Order(orderName);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.Find(id);
      return View(foundOrder);
    }
    [HttpGet("/vendor/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}