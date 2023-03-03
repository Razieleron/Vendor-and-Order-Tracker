using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace Orders.Tests 
{
  [TestClass]
  public class TrackTests
  {
    [TestMethod]
    public void TrackConstructor_CreateInstanceOfTrack_Track()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}