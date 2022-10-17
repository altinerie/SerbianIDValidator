using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogrulama
{
    public class Program
    {
        static void Main(string[] args)
        {
            string id;
            Console.WriteLine("Please enter your ID number:");
            id = Console.ReadLine();
            long idparse = Int64.Parse(id);

            int day = Int32.Parse(id.Substring(0, 2));
            int month = Int32.Parse(id.Substring(2, 2));
            int year = Int32.Parse(id.Substring(4, 3));
            int rr = Int32.Parse(id.Substring(7, 2));
            int checkSum = Int32.Parse(id.Substring(12, 1));



            if (idparse.ToString().Length != 13)
            {
                Console.WriteLine("ID number must be 13 digits long.");
            }


            else if (idparse.ToString().Length == 13)
            {
                if (day > 0 && day < 32 || month > 0 && month < 13 || year > 000 && year < 999 || rr > 69 && rr < 90 || checkSum > 000)
                {
                    Console.WriteLine("ID number is valid.");
                }
                else if (rr < 70 && rr > 89)
                {
                    Console.WriteLine("Invalid Region. Serbia region is between 70-89");
                }
                else
                {
                    Console.WriteLine("invalid id number");
                }
            }
        }


    }
}

