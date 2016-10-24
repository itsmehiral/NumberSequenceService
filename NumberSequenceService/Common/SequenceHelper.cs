using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SequenceHelper : ISequenceHelper
    {
        public long ValidateSequenceInput(string input)
        {
            string trimmedInput = input.Trim();
            ValidateInputRequired(trimmedInput);
            long numericInput = ValidateInputNumeric(trimmedInput);
            ValidateInputRange(numericInput);
            return numericInput;
        }
        private void ValidateInputRequired(string input)
        {
            if (input == string.Empty)
            {
                throw new Exception("Please enter valid whole number.");
            }
        }

        private long ValidateInputNumeric(string input)
        {
            try
            {
                var res = Convert.ToInt64(input);
                return res;
            }
            catch (OverflowException)
            {
                throw new Exception(string.Format("{0} is outside the range of the Int64 type.", input));
            }
            catch (FormatException)
            {
                throw new Exception(string.Format("The {0} value '{1}' is not in a recognizable format.",
                                  input.GetType().Name, input));

            }
        }
        private void ValidateInputRange(long input)
        {
            if(input > 99999)
            {
                throw new Exception(string.Format("The input number {0} is out of range of 9999. Please enter number less than 99999.", input));
            }
        }

    }
}
