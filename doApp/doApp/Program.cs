using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        static public void doApp()
        {
            bool xbool = true;
            byte xbyte = 250;
            sbyte xsbyte = -100;
            char xchar = 'a';
            decimal xdecimal = 87.9M;
            double xdouble = 651.09;
            float xfloat = 465.1f;
            int xint = -8909;
            uint xuint = 91881;
            long xlong = -1313131312;
            ulong xulong = 01919181;
            object xobject = new object();
            short xshort = -19;
            ushort xushort = 19;
            string xstring = "name";

            if (xbool == true && xbyte < 300)
                Console.WriteLine("This expression evaluates to true");
            if (xshort > 6 || xint > -9000)
                Console.WriteLine("This expression evaluates to false");

            int sum = xint + (int)xulong; // Casting ulong to int for addition
            double product = xdouble * xfloat;
            decimal difference = xdecimal - (decimal)xshort; // Casting short to decimal for subtraction

            // Print the results of the operations and read the values
            Console.WriteLine("Values after operations:");
            Console.WriteLine($"xbool: {xbool}");
            Console.WriteLine($"xbyte: {xbyte}");
            Console.WriteLine($"xsbyte: {xsbyte}");
            Console.WriteLine($"xchar: {xchar}");
            Console.WriteLine($"xdecimal: {xdecimal}");
            Console.WriteLine($"xdouble: {xdouble}");
            Console.WriteLine($"xfloat: {xfloat}");
            Console.WriteLine($"xint: {xint}");
            Console.WriteLine($"xuint: {xuint}");
            Console.WriteLine($"xlong: {xlong}");
            Console.WriteLine($"xulong: {xulong}");
            Console.WriteLine($"xobject: {xobject}");
            Console.WriteLine($"xshort: {xshort}");
            Console.WriteLine($"xushort: {xushort}");
            Console.WriteLine($"xstring: {xstring}");

            Console.WriteLine($"Sum of xint and xulong: {sum}");
            Console.WriteLine($"Product of xdouble and xfloat: {product}");
            Console.WriteLine($"Difference of xdecimal and xshort: {difference}");
            Console.ReadKey();



        }
    }
}
