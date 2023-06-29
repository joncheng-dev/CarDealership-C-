using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Entry
  {
    public string VehicleType { get; set; }
    public int VehicleYear { get; set; }
    public string VehicleMake { get; set; }
    public string VehicleModel { get; set; }

    private static List<Entry> _instances = new List<Entry> { };

    public Entry(string type, int year, string make, string model)
    {
      VehicleType = type;
      VehicleYear = year;
      VehicleMake = make;
      VehicleModel = model;
      _instances.Add(this);
    }

    public static List<Entry> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}