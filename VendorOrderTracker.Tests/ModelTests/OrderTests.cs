using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using VendorOrderTracker.Models;
namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {

    }

    [TestMethod]
    public void OrderConstructor_InstanceOfOrderCreated_Order()
    {
      DateTime date1 = new DateTime(2020, 5, 25);
      Order newOrder = new Order("", "", 0, 0.00m, date1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_PropertiesCreatedOnIntantiation_StringStringIntIntDate()
    {
      DateTime date1 = new DateTime(2020, 5, 25);
      string name = "Croissants";
      string description = "Underdone";
      int quantity = 40;
      decimal price = 85.00m;
      Order newOrder = new Order(name, description, quantity, price, date1);
      Assert.AreEqual(name, newOrder.Name);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(quantity, newOrder.Quantity);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(date1, newOrder.Date);
    }
    [TestMethod]
    public void OrderConstructor_PropertiesCreatedOnIntantiationOverloadedPrice_StringStringIntIntDate()
    {
      DateTime date1 = new DateTime(2020, 5, 25);
      string name = "Croissants";
      string description = "Underdone";
      int quantity = 40;
      Order newOrder = new Order(name, description, quantity, date1);
      Assert.AreEqual(name, newOrder.Name);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(quantity, newOrder.Quantity);
      Assert.AreEqual(80.00m, newOrder.Price);
      Assert.AreEqual(date1, newOrder.Date);
    }


  }


}