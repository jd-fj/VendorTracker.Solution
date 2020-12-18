using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorInstances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorInstances.Add(this);
      Id = _vendorInstances.Count;
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      Vendor failVendor = new Vendor("vendorName", "vendorDescription");
      Vendor failVendor2 = new Vendor("vendorName2", "vendorDescription2");
      return _vendorInstances;
    }
    
    public static void ClearAll()
    {
      _vendorInstances.Clear();
    }
    
  }
}
