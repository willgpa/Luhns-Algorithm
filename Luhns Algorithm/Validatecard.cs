using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhns_Algorithm
{
    public static class CardValidator
    {
        public static bool Validate(string cardNumber)
        {
            try
            {
                int sum = 0;
                bool isSecond = false;

                for (int i = cardNumber.Length - 1; i >= 0; i--)
                {
                    int digit = cardNumber[i] - '0';

                    // Double the value of every second digit
                    if (isSecond)
                    {
                        digit *= 2;
                    }

                    // Add two digits to handle cases like 10, 12, etc
                    sum += digit / 10;
                    sum += digit % 10;

                    // Toggle isSecond on and off
                    isSecond = !isSecond;
                }

                // Card is valid if sum modulo 10 is zero
                return (sum % 10 == 0);
            }
            catch
            {
                // Return false if any error occurs during the validation process
                return false;
            }
        }
    }
}
