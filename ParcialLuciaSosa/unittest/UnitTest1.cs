using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodget()
        {
            //arange
            CountriesController countriescontroller = new CountriesController();
            //act

            var resultado = countriescontroller.GetCountries();

            //assert
            Assert.IsNotNull(resultado);
        }
    }
}
