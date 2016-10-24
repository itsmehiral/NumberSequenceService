using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Microsoft.Practices.Unity;

namespace NumberSequenceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NumberSequence : INumberSequence
    {
      
        public string GetAllNumbers(long number)
        {
            var allNum = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                allNum.Add(i);
            }
            return string.Join(" ", allNum);

        }
        public string GetOddNumbers(long number)
        {
            var oddNum = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                    oddNum.Add(i);
            }

            return string.Join(" ", oddNum);
        }

        public string GetEvenNumbers(long number)
        {
            var evenNum = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNum.Add(i);
                }
            }
            return string.Join(" ", evenNum);

        }

        public string GetFormattedNumbers(long number)
        {

            var formattedNum = new List<string>();
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    formattedNum.Add("Z");
                else if (i % 3 == 0)
                    formattedNum.Add("C");
                else if (i % 5 == 0)
                    formattedNum.Add("E");
                else
                    formattedNum.Add(Convert.ToString(i));
            }
            return string.Join(" ", formattedNum);

        }

        public string GetFibonacciNumbers(long number)
        {

            var fibo = new List<int> { 0, 1 };
            int j = 0;
            for (int i = 2; i <= number; i++)
            {
                j = fibo[i - 1] + fibo[i - 2];
                if (j > number)
                    break;
                fibo.Add(j);
            }

            return string.Join(" ", fibo);

        }

    }
}
