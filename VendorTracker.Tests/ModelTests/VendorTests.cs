using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;


namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
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
    [TestMethod]
    public void GetVendors_ReturnsAllVendorObjs_VendorInstance()
    {
      Vendor newVendor = new Vendor("vendorName", "vendorDescription");
      Vendor newVendor2 = new Vendor("vendorName2", "vendorDescription2");
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };
      List<Vendor> getResults = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, getResults);
    }
  }
}