using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDuplicateOperands
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =4, y=4;
            try
            {
                RandomMethod(x, y);
            }
            catch (NoDuplicateOperandsException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static void RandomMethod(int a, int b)
        {
            
            try
            {
                int add = a + b;
                
            }
            catch(NoDuplicateOperandsException e)
            {
                if(a == b)
                {
                    throw e;
                }
            }
            
        }

        class NoDuplicateOperandsException : Exception
        {
            public NoDuplicateOperandsException() { }

            public NoDuplicateOperandsException(string msg) 
                :base(String.Format("No Duplicate Operands Allowed! {0}", msg))
            {
                msg = "No Duplicate Operands Allowed!";
            }
        }
    }
}
