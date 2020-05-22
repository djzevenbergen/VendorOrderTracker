using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public DateTime Date = new DateTime();

    private static List<Order> _instances = new List<Order> { };

    public Order(string name, string description, int quantity, DateTime date)
    {
      Name = name;
      Description = description;
      Quantity = quantity;
      Price = CalculatePrice(name, quantity);
      Date = date;
      _instances.Add(this);
    }
    public Order(string name, string description, int quantity, decimal price, DateTime date)
    {
      Name = name;
      Description = description;
      Quantity = quantity;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static decimal CalculatePrice(string name, int quantity)
    {
      name = name.ToLower();
      decimal unitPrice = 0.00m;
      switch (name)
      {
        case "croissants":
          unitPrice = 2.00m;
          break;
        case "cookies":
          unitPrice = 1.50m;
          break;
        case "muffins":
          unitPrice = 2.50m;
          break;
        default:
          unitPrice = 3.00m;
          break;
      }
      return unitPrice * quantity;
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }

    public static Order Find(int id)
    {
      Order ord = null;
      foreach (Order o in _instances)
      {

        if (o.Id == id)
        {
          ord = o;
        }
      }
      return ord;
    }
  }
}