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
      Price = 0;
      Date = date;
      _instances.Add(this);

    }

  }
}