/*Programmer: Solomon Rantlhago
 *purpose:   transaction at a cashier in a grocery store
 */

using System;

namespace Transaction_Grocerystore
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            decimal mTotalCost = GetAmount("Enter total cost of purchased items.Value must be Positive: ");
            decimal mAmountoffered = 0;
            do
            {
                mAmountoffered = GetAmount("Enter Value of Cash offered.Value Must be atleast " + mTotalCost.ToString("C") + ": ");
            } while (!(mAmountoffered >= mTotalCost));

            decimal mchange = mAmountoffered - mTotalCost;

            if (mchange > 0)
            {
                Console.WriteLine("Thank you. Here is your " + mchange.ToString("C") + " Change");
            }
            else
            {
                Console.WriteLine("Thank you. you have no change");
            }

            Console.WriteLine("\npress any key to exit");



            Console.ReadKey();
        }

        private static decimal GetAmount(string sPrompt)
        {
            Console.Write(sPrompt);
            string SAmount = Console.ReadLine();
            decimal mAmount = 0;
            bool isTrue = decimal.TryParse(SAmount, out mAmount);

            if (!isTrue || mAmount<0)
            {
                Console.Write("Invalid Input Entered.\n\n\nPress any key to restart......");
                Console.ReadKey();
                Main();
            }
            return mAmount;
        }
    }
}
