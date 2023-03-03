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
    }
  } 