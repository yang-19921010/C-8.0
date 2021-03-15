using System;

namespace Charter02
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber = 23;
            int integerNumber = -23;
            float realNumber = 2.3F;
            double anotherRealNumber = 2.3;
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{binaryNotation == hexadecimalNotation}");
            double a = 0.1;
            double b = 0.2;
            if(a +b ==0.3){
                Console.WriteLine($"{a} + {b} 等于 0.3");
            }else{
                Console.WriteLine($"{a} + {b} 不等于 0.3");
            }
        }
    }
}
