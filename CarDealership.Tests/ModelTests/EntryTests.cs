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
  }
}