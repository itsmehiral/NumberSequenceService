using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NumberSeqenceWeb.NumberSequenceReference;
using Microsoft.Practices.Unity;
namespace NumberSeqenceWeb
{
    public class ServiceManager
    {
        private INumberSequence client;
        public ServiceManager()
        {
            client = new NumberSequenceClient();

        }
        public ServiceManager(IUnityContainer container)
        {
            client = container.Resolve<INumberSequence>();

        }
        public SequenceResponseModel GetSequences(SequenceRequestModel model)
        {
            long input = model.InputNumber;
           

            string getAllNum = client.GetAllNumbers(input);
            string getOddNum = client.GetOddNumbers(input);
            string getEvenNum = client.GetEvenNumbers(input);
            string getFormNum = client.GetFormattedNumbers(input);
            string getFiboNum = client.GetFibonacciNumbers(input);


            Dictionary<string, string> dicSeq = new Dictionary<string, string>();
            dicSeq.Add("All Numbers", getAllNum);
            dicSeq.Add("Odd Numers", getOddNum);
            dicSeq.Add("Even Numbers", getEvenNum);
            dicSeq.Add("Formatted Numbers", getFormNum);
            dicSeq.Add("Fibonacci Numbers", getFiboNum);


            SequenceResponseModel respModel = new SequenceResponseModel()
            {
                Sequences = dicSeq
            };

            return respModel;

            
        }
    }
}