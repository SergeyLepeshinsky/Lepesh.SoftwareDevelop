using Lepesh.SoftwareDevelop.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Lepesh.SoftwareDevelop.SoftwareDevelopTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ManagerTotalPay()
        {
            Manager manager = new Manager("test", new List<TimeRecord>() {
                new TimeRecord(DateTime.Now.AddDays(-3), "test",8,"test message"),
                new TimeRecord(DateTime.Now.AddDays(-2), "test",9,"test message"),
                new TimeRecord(DateTime.Now.AddDays(-1), "test",7,"test message"),});

            // 29750 = 10000+11000+8750
            Assert.IsTrue(manager.TotalPay == 29750);
            //Assert.Pass();  // по умолчанию стоит что тест пройден
        }
        [Test]
        public void ManagerTotalPay2()
        {
            Manager manager = new Manager("test", new List<TimeRecord>() {
                new TimeRecord(DateTime.Now.AddDays(-3), "test",8,"test message") });
            Assert.IsTrue(manager.TotalPay == 10000);
           
        }
    }
}