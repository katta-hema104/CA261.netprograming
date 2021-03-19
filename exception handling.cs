using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter 1ST number");
                int x = int.Parse(Console.ReadLine());
                Console.Write("enter 2nd number");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("the result is" + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.Write(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.Write("input must be numeric");
            }
            catch (Exception ex)
            {
                Console.Write("ex,message");
            }
            Console.WriteLine("end of the programm");
            Console.ReadLine();
        }
    }
}


