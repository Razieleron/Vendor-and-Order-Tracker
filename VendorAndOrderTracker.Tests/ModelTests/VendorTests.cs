using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
  [TestMethod]
  public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
  {
    Vendor newVendor = new Vendor("Maria's Muffins");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }
  }
}