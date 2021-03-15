using System;
using static System.Console;
namespace BooleanOperatros
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 逻辑运算符
            // bool a = true;
            // bool b = false;
            // WriteLine("AND | a | b ");
            // WriteLine($"a  | {a & a} | {a & b} |");
            // WriteLine($"b  | {b & a} | {b & b} |");
            // WriteLine();
            // WriteLine("OR | a | b ");
            // WriteLine($"a  | {a | a} | {a | b} |");
            // WriteLine($"b  | {b | a} | {b | b} |");
            // WriteLine();
            // WriteLine("XOR | a | b ");
            // WriteLine($"a  | {a ^ a} | {a ^ b} |");
            // WriteLine($"b  | {b ^ a} | {b ^ b} |");
            #endregion

            #region 按位和二元移位运算符
            int a = 11; //00001010
            int b = 6;  //00000110
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}"); //相同位的两个数字都为1，则为1；若有一个不为1，则为0。
            WriteLine($"a | b = {a | b}"); //相同位只要一个为1即为1。
            WriteLine($"a ^ b = {a ^ b}"); //不同则该位为1, 否则该位为0.
            WriteLine($"a << 3 = {a << 3}"); //相当于a乘以2的b次方
            WriteLine($"a * 8 = {a * 8}");
            WriteLine($"b >> 1 = {b >> 1}"); //相当于a除以2的b次方（取整）
            #endregion
        }
    }
}
