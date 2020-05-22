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
  }
}