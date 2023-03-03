using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; }
    // public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
    }
  }
}