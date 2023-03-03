using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace Orders.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {
      public void Dispose()
    {
      Order.ClearAll();
    }
  
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]

    public void GetOrderName_ReturnOrderName_String()
    {
      string orderName = "Frozen";
      Order newOrder = new Order(orderName);
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }
    [TestMethod]

    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrderList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}