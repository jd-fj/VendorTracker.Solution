using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string newOrderTitle = "Lindas b&b";
      string newOrderDescription = "Lindas b&b Description";
      string newOrderDate = "12-18-20";
      int newOrderPrice = 100;
      Order newOrder = new Order(newOrderTitle, newOrderDescription, newOrderDate, newOrderPrice);
      Assert.AreEqual(newOrderTitle, newOrder.Title);
    }
  }
}