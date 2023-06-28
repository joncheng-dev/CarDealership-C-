using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Entry
  {
    public string VehicleType { get; set; }
    
    public Entry(string vehicleType)
    {
      VehicleType = vehicleType;
    }
  }
}