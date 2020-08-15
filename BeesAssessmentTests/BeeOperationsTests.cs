using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeesAssessment;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeesAssessment.Tests
{
    [TestClass()]
    public class BeeOperationsTests
    {
        BeeOperations beeOps = new BeeOperations();
        List<Bee> beeList = new List<Bee>();

        [TestMethod()]
        public void TestGeneration()
        {
            beeOps.GenerateBees();
            beeList = beeOps.GetBees();
            Assert.AreEqual(30, beeList.Count);
        }
    }
}