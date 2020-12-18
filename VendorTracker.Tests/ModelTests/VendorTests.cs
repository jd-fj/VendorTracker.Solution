using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;


namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesAnInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("vendor name", "vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}