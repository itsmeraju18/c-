//C#: Throw Exception Handling
using System;

namespace Throw_Exception
{
    class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                throw new DivideByZeroException("Invalid Division");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception");
            }
            Console.WriteLine("LAST STATEMENT");
        }
            
        }
    }

