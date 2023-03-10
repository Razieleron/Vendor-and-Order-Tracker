using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public int Id { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public Order(string orderName)
    {
      OrderName = orderName;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
