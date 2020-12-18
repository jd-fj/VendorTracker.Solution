using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
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
      string newOrderTitle = "Linda's b&b";
      Order newOrder = new Order(newOrderTitle);
      Assert.AreEqual(newOrderTitle, newOrder.Title);
    }
  }
}