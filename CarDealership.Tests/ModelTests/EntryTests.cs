using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class EntryTests
  {
  // public class EntryTests : IDisposable
  // {
    // public void Dispose()
    // {
    //   Entry.ClearAll();
    // }

    [TestMethod]
    public void EntryConstructor_CreatesInstanceOfEntry_Entry()
    {
      Entry newEntry = new Entry("minivan", 2000);
      Assert.AreEqual(typeof(Entry), newEntry.GetType());
    }

    [TestMethod]
    public void GetVehicleType_ReturnsVehicleType_String()
    {
      string description = "minivan";
      Entry newEntry = new Entry(description, 2000);
      string result = newEntry.VehicleType;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetVehicleType_SetsValueOfVehicleType_Void()
    {
      Entry newEntry = new Entry("minivan", 2000);
      string editedDescription = "SUV";
      newEntry.VehicleType = editedDescription;
      Assert.AreEqual(editedDescription, newEntry.VehicleType);
    }

    [TestMethod]
    public void GetVehicleYear_ReturnsVehicleYear_Int()
    {
      string description = "minivan";
      int year = 2023;
      Entry newEntry = new Entry(description, year);
      int checkYear = newEntry.VehicleYear;
      Assert.AreEqual(year, checkYear);
    }

    [TestMethod]
    public void SetVehicleYear_SetsValueOfVehicleYear_Void()
    {
      Entry newEntry = new Entry("minivan", 2000);
      int editedVehicleYear = 2023;
      newEntry.VehicleYear = editedVehicleYear;
      Assert.AreEqual(editedVehicleYear, newEntry.VehicleYear);
    }
  }
}