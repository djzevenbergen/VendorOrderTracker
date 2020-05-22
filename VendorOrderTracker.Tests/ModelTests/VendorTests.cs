using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}