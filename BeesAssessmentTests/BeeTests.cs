using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeesAssessment;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeesAssessment.Tests
{
    [TestClass()]
    public class BeeTests
    {
        private Bee bee = new Bee();

        [TestMethod()]
        public void WorkerHealthDamageTest()
        {
            Worker worker = new Worker(100);
            string actual = worker.Damage(30);
            Assert.AreEqual("Health status: 70 Alive :)", actual);

            Worker worker2 = new Worker(100);
            string actual2 = worker2.Damage(31);
            Assert.AreEqual("Health status: Dead :( ", actual2);
        }

        [TestMethod()]
        public void QueenHealthDamageTest()
        {
            Queen queen = new Queen(100);
            string actual = queen.Damage(80);
            Assert.AreEqual("Health status: 20 Alive :)", actual);

            Queen queen2 = new Queen(100);
            string actual2 = queen2.Damage(81);
            Assert.AreEqual("Health status: Dead :( ", actual2);
        }

        [TestMethod()]
        public void DroneHealthDamageTest()
        {
            Drone drone = new Drone(100);
            string actual = drone.Damage(50);
            Assert.AreEqual("Health status: 50 Alive :)", actual);

            Drone drone2 = new Drone(100);
            string actual2 = drone2.Damage(51);
            Assert.AreEqual("Health status: Dead :( ", actual2);
        }
    }
}