using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableSwapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int FN, SN, Temp;

            Console.WriteLine("Enter the first number:");
            FN = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the socond number:");
            SN = int.Parse(Console.ReadLine());

            Temp = SN;
            SN = FN;
            FN = Temp;

            Console.WriteLine("Value after swapping:\n First number: {0} \n Second number: {1}", FN, SN);

            Console.ReadLine();

        }
    }
}
