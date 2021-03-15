using System;
Console.WriteLine("hello");
using System.IO;
using static System.Console;
namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {           
            #region  模式匹配与if语句
            // object o = "3";
            // int j =4;
            // if(o is int i){
            //     WriteLine($"{i} * {j} = {i * j}");
            // }else{
            //     WriteLine("o is not int");
            // }
            #endregion
            #region  switch
            // A_label:
            // var number = (new Random()).Next(1,7);
            // WriteLine($"My random number is {number}");
            // switch(number){
            //     case 1:
            //       WriteLine("1");
            //       break;
            //     case 2:
            //       WriteLine("2");
            //       goto case 1;
            //     case 3:
            //     case 4:
            //        System.Threading.Thread.Sleep(5000);
            //        goto A_label;
            //     default:
            //        break;
            // }
            #endregion
            #region  switch与模式匹配
             string path = @"E:\";
             Stream s = File.Open(Path.Combine(path,"file.txt"),FileMode.OpenOrCreate);
             string message = string.Empty;
             switch(s){
                case FileStream writeableFile when s.CanWrite:
                message = "I can write to";
                break;
                case FileStream readOnlyFile:
                WriteLine("2");
                break;
                case MemoryStream ms:
                WriteLine("3");
                break;
                default:
                break;
             }
             WriteLine(message);
             message = s switch
             {
                 FileStream writeableFile when s.CanWrite
                  => "I can write",
                 _
                  => "orther"
             };
              WriteLine(message);
            #endregion

        }
    }
}
