using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata.Models;

namespace VendingMachineKata.Tests.ModelsTest
{
    [TestClass]
    public class VendingMachineTest
    {
        VendingMachine vm;

        [TestInitialize]
        public void SetUp()
        {
            vm = new VendingMachine();
        }

        [TestMethod]
        public void VendingMachineAcceptsNickel()
        {
            vm.insert("nickel");
            Assert.AreEqual("0.05", vm.getDisplay());
        }

        [TestMethod]
        public void VendingMachineAcceptsDime()
        {
            vm.insert("dime");
            Assert.AreEqual("0.10", vm.getDisplay());
        }

        [TestMethod]
        public void VendingMachineAcceptsQuarters()
        {
            vm.insert("quarter");
            Assert.AreEqual("0.25", vm.getDisplay());
        }
    }
}
