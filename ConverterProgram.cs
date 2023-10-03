using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab_
{
    class Converter
    {
        private decimal Dollar, Euro;
        Converter(decimal dollar, decimal euro)
        {
            Dollar = dollar;
            Euro = euro;
        }
    }

    internal class ConverterProgram
    {
        static void Main(string[] args)
        {
            decimal dollar = 1, euro = 1;
            int failCount = 0;            
            bool success = false;
            while ((failCount < 2) & !success)
            {
                do
                {
                    Console.WriteLine("Enter dollar's value");
                    try
                    {
                        dollar = Convert.ToDecimal(Console.ReadLine());
                        if (dollar <= 0)
                        {
                            failCount++;
                            Console.WriteLine("You can set up only positive value, try again");
                        }
                        else success = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message + "try again");
                        failCount++;
                    }
                } while ((failCount < 2) & !success);
            }
            failCount = 0;
            success = false;
            while ((failCount < 2) & !success)
            {
                Console.WriteLine("Enter euro's value");
                try
                {
                    do
                    {
                        euro = Convert.ToDecimal(Console.ReadLine());
                        if (euro <= 0)
                        {
                            failCount++;
                            Console.WriteLine("You can set up only positive value, try again");
                        }
                        else success = true;
                    } while ((failCount < 2) & !success);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message + "try again");
                    failCount++;
                }
            }
            failCount = 0;
            success = false;
            string userInput = "";
            decimal userCurrency = 1;
            bool convertToHryvnia = false;
            while ((failCount < 2) & !success)
            {
                Console.WriteLine("Choose currency you want convert to (dollar/euro/hryvnia)");
                userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "dollar")
                {
                    userCurrency = dollar;
                    success = true;
                }
                else if (userInput == "euro")
                {
                    userCurrency = euro;
                    success = true;
                }
                else if (userInput == "hryvnia")
                {
                    convertToHryvnia = true;
                    success = true;
                }
                else
                {
                    Console.WriteLine("Only dollar and euro are available on the market, try again");
                    failCount++;
                }
            }                
            failCount = 0;
            success = false;
            decimal userMoney = 0;
            Console.WriteLine("How much money you would like to convert?");
            while ((failCount < 2) & !success)
            {
                try
                {
                    do
                    {
                        userMoney = Convert.ToDecimal(Console.ReadLine());
                        if (userMoney <= 0)
                        {
                            failCount++;
                            Console.WriteLine("You can convert only positive amount of money, try again");
                        }
                        else success = true;
                    } while ((failCount < 2) & !success);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message + "try again");
                    failCount++;
                }
            }
            if ((failCount < 2) & !convertToHryvnia)
            {
                userMoney = userMoney / userCurrency;
                Console.WriteLine("Success, you now have " + userMoney + " " + userInput + "s");
            }
            else if((failCount < 2) & convertToHryvnia)
            {
                failCount = 0;
                success = false;
                while ((failCount < 2) & !success)
                {
                    Console.WriteLine("Choose currency you want convert from (dollar/euro)");
                    userInput = Console.ReadLine().Trim().ToLower();
                    if (userInput == "dollar")
                    {
                        userCurrency = dollar;
                        success = true;
                    }
                    else if (userInput == "euro")
                    {
                        userCurrency = euro;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Only dollar and euro are available on the market, try again");
                        failCount++;
                    }
                }
                if (failCount < 2)
                {
                    userMoney = userMoney * userCurrency;
                    Console.WriteLine("Success, you now have " + userMoney + " hryven'");
                }
            }
            Console.ReadKey();
        }
    }
}
