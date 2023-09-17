using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RakhmatullinKK.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {

            var name = "Karim";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Privet, Karim", res);
        }
    }
}
