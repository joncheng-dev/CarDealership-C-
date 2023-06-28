using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Entry
  {
    public string VehicleType { get; set; }
    public int VehicleYear { get; set; }
    public string VehicleMake { get; set; }

    public Entry(string type, int year, string make)
    {
      VehicleType = type;
      VehicleYear = year;
      VehicleMake = make;
    }
  }
}