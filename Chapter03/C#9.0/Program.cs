using System;
using static System.Console;
using static System.Convert;

#region  while
//  int x = 0;
//  while (x <10)
//  {
//      WriteLine(x);
//      x++;
//  }
#endregion

#region  do
// string password = string.Empty;
// int x = 0;
// do{
//   if(x < 5){
//     WriteLine("Enter your password:");
//     password = ReadLine();
//     x++;
//   }else{
//     WriteLine("输入错误，请重新输入：");
//     x =0;
//   }
// }while(password != "123456");

// WriteLine("成功");
#endregion

#region  类型转换
 //转换数字
//  int a = 10;
//  double  b = a;
//  WriteLine(b);
//  double c = 9.8;
//  int d = (int)c;
//  WriteLine(d);
 //Convert：圆整规则：小数部分大于0.5向上园整，小于0.5向下园整
 //如果小数部分是0.5，那么非小数部分是奇数的情况下向上，偶数的情况向下（C#，“银行家园整法”）
 //Round()向上园整
//  int e = ToInt32(c);
//  WriteLine(e);
 //二进制对象转换为字符串
//  byte[] binaryObject = new byte[128];
//  (new Random()).NextBytes(binaryObject);
//  WriteLine("Binary Object as bytes:");

//  for(int index = 0; index < binaryObject.Length; index++){
//      Write($"{binaryObject[index]:X}");
//  }
//  WriteLine();

//  String encoded = ToBase64String(binaryObject);
//  Write($"Binary Object as Base64: {encoded}" );
 //将字符串转换为数字或日期和时间
//  int age= int.Parse("27");
//  DateTime birthday;
//  bool isDate = DateTime.TryParse("4 July 1980",out birthday);
//  WriteLine(isDate);
//检查溢出
// checked{
//     int x = int.MaxValue - 1;
//     WriteLine(x);
//     x++;
//     WriteLine(x);
//     x++;
//     WriteLine(x);
//     x++;
//     WriteLine(x);
// }
// //关闭溢出
// unchecked{
// int y = int.MaxValue + 1;
// WriteLine(y);
// }
int x;
int y;
x = 10 & 7;
y = 10 | 7;
WriteLine(x);
WriteLine(y);
#endregion