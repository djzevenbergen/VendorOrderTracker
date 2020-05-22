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
      Order newOrder = new Order("", "", 0, date1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }


}