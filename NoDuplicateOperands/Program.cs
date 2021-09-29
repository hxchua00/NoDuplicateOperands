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
            int x = 4, y = 4;

            try
            {
                int res1 = RandomMethod1(x, y);
                int res2 = RandomMethod2(x, y);
            }
            catch (MyArgumentExveption e)
            {
                Console.WriteLine(e.Message);
            }
            
            
           

            Console.ReadLine();
        }

        public static int RandomMethod1(int a, int b)
        {

            int add = a + b;

            if(a == b)
            {
                throw new MyArgumentExveption(a, b);
            }
            return add;

        }
        public static int RandomMethod2(int a, int b)
        {

            int subtract = a - b;

            if (a == b)
            {
                throw new MyArgumentExveption(a, b);
            }
            return subtract;

        }

        class MyArgumentExveption : Exception
        {
            private static readonly string ErrMessage = "No Duplicate Operands Allowed!";

            public int x { get; set; }
            public int y { get; set; }
            public MyArgumentExveption() { }

            public MyArgumentExveption(int x, int y) 
                :base(ErrMessage)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
