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
      string vendorName = "vendor name";
      string vendorDescription = "vendor description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorProperties_ReturnsPropertiesOfVendor_VendorName()
    {
      string vendorName = "vendor name";
      string vendorDescription = "vendor description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      Assert.AreEqual(vendorName, newVendor.Name);
    }
  }
}