using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using NumberSequenceTests.NumberSequenceServiceReference;
using System.Collections.Generic;
using System.ServiceModel;
using Common;

namespace NumberSequenceTests
{
    [TestClass]
    public class UnitTest1
    {
        INumberSequence client = null;
        
        
        [TestInitialize]
        public void TestInitialize()
        {
            var container = new UnityContainer();

            container.RegisterInstance<NumberSequenceClient>(new NumberSequenceClient());
            container.RegisterType<ISequenceHelper, SequenceHelper>();
            client = new NumberSequenceClient();
            
            //container.Resolve<INumberSequence>();
            
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void TestGetAllNumbersExpectedExceptionNegativeInput()
        {
            client.GetAllNumbers("-10");
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void TestGetAllOddNumbersExceptedExceptionNegativeInput()
        {
            client.GetAllNumbers("-10");
        }
      
        [TestMethod]
        public void TestGetAllNumbersPositiveNumberInput()
        {
            var result = client.GetAllNumbers("10");
            string match = "0 1 2 3 4 5 6 7 8 9 10";
            Assert.AreEqual(match, result);
        }

        [TestMethod]
        public void TestGetAllNumbersZeroNumberInput()
        {
            var result = client.GetAllNumbers("0");
            string match = "0";
            Assert.AreEqual(match, result);
        }

        [TestMethod]
        public void TestGetOddNumbersPositiveNumberInput()
        {
            var result = client.GetOddNumbers(10);
            string match = "1 3 5 7 9";
            Assert.AreEqual(match, result);
        }

        [TestMethod]
        public void TestGetEvenNumbersPositiveNumberInput()
        {
            var result = client.GetEvenNumbers(10);
            string match = "0 2 4 6 8 10";
            Assert.AreEqual(match, result);
        }

        [TestMethod]
        public void TestGetFormattedNumbersPositiveNumberInput()
        {
            var result = client.GetFormattedNumbers(15);
            string match = "Z 1 2 C 4 E C 7 8 C E 11 C 13 14 Z";
            Assert.AreEqual(match, result);
        }

        [TestMethod]
        public void TestGetFibonacciNumbersPositiveNumberInput()
        {
            var result = client.GetFibonacciNumbers(25);
            string match = "0 1 1 2 3 5 8 13 21";
            Assert.AreEqual(match, result);
        }
    }
}
