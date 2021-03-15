using System;
using static System.Console;
using System.Diagnostics;

namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
             Debug.WriteLine("aa");
            RunTimesTable();
        }

        static void TimeTable(byte number){
            WriteLine($"{number}的乘法表");
            for(int row = 1;row <= 12;row++){
               WriteLine($"{row} x {number} = {row * number}");
            }
        }

        static void RunTimesTable(){
            bool isNumber;
            do{
              WriteLine("请输入数字0~255之间：");
              isNumber =  byte.TryParse(ReadLine(),out byte number);
             
              if(isNumber){
                  TimeTable(number);
              }else{
                  WriteLine("您输入的不是数字！");
              }
            }
            while(isNumber == false);
        }
    }
}
