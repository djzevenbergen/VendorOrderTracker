using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    //public List<Order> Orders = new List<Order> { };
    public int Id { get; }
    private static int _currentId = 0;
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name)
    {
      Name = name;
      _currentId++;
      Id = _currentId;
      _instances.Add(this);
    }
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _currentId++;
      Id = _currentId;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
      _currentId = 0;
    }
  }
}
