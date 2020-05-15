using System;

namespace MySwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 0-10");
            string inputNr = Console.ReadLine();

            if (inputNr == "0" || inputNr == "1" || inputNr == "2" || inputNr == "0" || inputNr == "4")
                Console.WriteLine("Fail");
            else if (inputNr == "5")
                Console.WriteLine("Pass");
            else if (inputNr == "6")
                Console.WriteLine("Good");
            else if (inputNr == "7" || inputNr == "8")
                Console.WriteLine("Notable");
            else if (inputNr == "9" || inputNr == "10")
                Console.WriteLine("Excellent");
            else
                Console.WriteLine("Wrong input. Please enter a number between 0 - 10");


            //switch (inputNr)
            //{
            //    case "0":
            //    case "1":
            //    case "2":
            //    case "3":
            //    case "4":
            //        Console.WriteLine("Fail");
            //        break;

            //    case "5":
            //        Console.WriteLine("Pass");
            //        break;

            //    case "6":
            //        Console.WriteLine("Good");
            //        break;

            //    case "7":
            //    case "8":
            //        Console.WriteLine("Notable");
            //        break;

            //    case "9":
            //    case "10":
            //        Console.WriteLine("Excellent");
            //        break;

            //    default:
            //        Console.WriteLine("Please enter a number between 0-10");
            //        break;
            //}
        }
    }
}
