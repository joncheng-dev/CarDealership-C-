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
      Entry newEntry = new Entry("minivan");
      Assert.AreEqual(typeof(Entry), newEntry.GetType());
    }

    [TestMethod]
    public void GetVehicleType_ReturnsVehicleType_String()
    {
      string description = "minivan";
      Entry newEntry = new Entry(description);
      string result = newEntry.VehicleType;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetVehicleType_SetsValueOfVehicleType_Void()
    {
      Entry newEntry = new Entry("minivan");
      string editedDescription = "SUV";
      newEntry.VehicleType = editedDescription;
      Assert.AreEqual(editedDescription, newEntry.VehicleType);
    }
  }
}