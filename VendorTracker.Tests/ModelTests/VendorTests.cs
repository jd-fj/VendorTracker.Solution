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
    [TestMethod]
    public void FindVendor_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor = new Vendor("vendorName", "vendorDescription");
      Vendor newVendor2 = new Vendor("vendorName2", "vendorDescription2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrdersList()
    {
      Vendor newVendor = new Vendor("vendorName", "vendorDescription");
      Order newOrder = new Order("newOrderTitle", "newOrderDescription", "newOrderDate", 10);
      List<Order> newList = new List<Order> {newOrder};
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}