using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberSeqenceWeb;
using NumberSeqenceWeb.NumberSequenceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.Practices.Unity;


namespace NumberSeqenceWeb.Tests
{
    [TestClass]
    public class NumberSequenceWebTest
    {

        [TestMethod]
        public void MockGetSequences()
        {
            SequenceRequestModel model = new SequenceRequestModel();
            model.InputNumber = 2;
            Dictionary<string, string> dicSeq = new Dictionary<string, string>();
            dicSeq.Add("All Numbers", "0 1 2");
            dicSeq.Add("Odd Numers", "1");
            dicSeq.Add("Even Numbers", "0 2");
            dicSeq.Add("Formatted Numbers", "Z 1 2");
            dicSeq.Add("Fibonacci Numbers", "0 1 1 2");

            SequenceResponseModel actualRetVal = new SequenceResponseModel();

            // mock wcf interface
            Mock<INumberSequence> wcfMock = new Mock<INumberSequence>();

            // setup for wcf service GetAllNumbers method
            wcfMock.Setup<string>(s => s.GetAllNumbers(2)).Returns("0 1 2");
            wcfMock.Setup<string>(s => s.GetOddNumbers(2)).Returns("1");
            wcfMock.Setup<string>(s => s.GetEvenNumbers(2)).Returns("0 2");
            wcfMock.Setup<string>(s => s.GetFormattedNumbers(2)).Returns("Z 1 2");
            wcfMock.Setup<string>(s => s.GetFibonacciNumbers(2)).Returns("0 1 1 2");

            // create object to register with IoC
            INumberSequence wcfMockObject = wcfMock.Object;
            
            // register instance
            UnityContainer container = new UnityContainer();
            container.RegisterInstance<INumberSequence>(wcfMockObject);
           
            // create ServiceAgent object using parameterized constructor
            ServiceManager serviceAgent = new ServiceManager(container);

            // method call to be tested
            actualRetVal = serviceAgent.GetSequences(model);
            
          
            CollectionAssert.AreEqual(dicSeq, actualRetVal.Sequences, "Not same.");
        }
    }
}
