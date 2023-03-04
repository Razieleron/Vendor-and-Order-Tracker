using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
    public class VendorTests : IDisposable
    {
      public void Dispose()
      {
        Vendor.ClearAll();
      }
      [TestMethod]
      public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
      {

        
        Vendor newVendor = new Vendor("Maria's Muffins");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }
      [TestMethod]
      public void GetName_ReturnsVendorName_String()
      {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        string result = newVendor.Name;
        Assert.AreEqual(name, result);
      }
      [TestMethod]
      public void GetId_ReturnsVendorId_Int()
      {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
      }
      [TestMethod]
      public void GetAll_ReturnsAllVendorObjects_VendorList()
      {
        string name1 = "Vendor1";
        string name2 = "Vendor2";
        Vendor newVendor1 = new Vendor(name1);
        Vendor newVendor2 = new Vendor(name2);
        List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
        List<Vendor> result = Vendor.GetAll();
        CollectionAssert.AreEqual(newList, result);
      }
      [TestMethod]
      public void AddOrder_AssociatesOrderWithVendor_OrderList()
      {
        string orderName = "Frozen";
        Order newOrder = new Order(orderName);
        List<Order> newList = new List<Order> { newOrder };

        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        newVendor.AddOrder(newOrder);

        List<Order> result = newVendor.Orders;
        CollectionAssert.AreEqual(newList, result);
      }
    }
  } 