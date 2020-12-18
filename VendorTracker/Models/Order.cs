using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    private static List<Order> _orderInstances = new List<Order> {};

    public Order( string title, string description, string date, int price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _orderInstances.Add(this);
      Id = _orderInstances.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderInstances;
    }

    public static void ClearAll()
    {
      _orderInstances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orderInstances[searchId];
    }
  }
}