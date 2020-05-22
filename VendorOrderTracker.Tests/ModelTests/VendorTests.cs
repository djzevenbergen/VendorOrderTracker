using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_InstanceOfTypeVendorCreated_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_CreatesVendorWithCorrectProperties_StringStringInt()
    {
      string name = "Cathy's Cafe";
      string des = "Cathy always pays on time";
      Vendor newVendor = new Vendor(name, des);
      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(des, newVendor.Description);
      Assert.AreEqual(1, newVendor.Id);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_Order()
    {
      DateTime newDate = new DateTime(2020, 3, 3);
      Order testOrder = new Order("", "", 0, 0.00m, newDate);
      Vendor testVendor = new Vendor("hi", "hi");
      testVendor.AddOrder(testOrder);
      Assert.AreEqual(testOrder, testVendor.Orders[0]);
    }
  }
}