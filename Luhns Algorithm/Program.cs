using System;

namespace Luhns_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a credit card number, no dashes, and I will compute the validity of the format: ");
                String ccNumber;
                ccNumber = Console.ReadLine();
                if (ValidateCard(ccNumber))
                {
                    Console.WriteLine("That number is valid.");
                } else {
                    Console.WriteLine("That number does not appear to be valid.");
                }
            }
        }
        public static bool ValidateCard(String cardNumber)
        {
            try
            {
                int cardLength = cardNumber.Length;

                int sum = 0;
                bool isSecond = false;
                for (int i = cardLength - 1; i >= 0; i--)
                {
                    int digit = cardNumber[i] - '0';

                    if (isSecond)
                    {
                        // Double every 2nd digit
                        digit *= 2;
                    }

                    sum += digit / 10;
                    sum += digit % 10;

                    isSecond = !isSecond; //Set it to the opposite of its current valid, switches back and forth between true and false
                }

                // If a multiple of 10, card is valid
                return (sum % 10 == 0);
            } catch (Exception) {
                return false;
            }
        }
    }
}
