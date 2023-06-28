using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Entry
  {
    public string VehicleType { get; set; }
    public int VehicleYear { get; set; }

    public Entry(string vehicleType, int vehicleYear)
    {
      VehicleType = vehicleType;
      VehicleYear = vehicleYear;
    }
  }
}