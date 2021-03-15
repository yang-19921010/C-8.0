using System;
using Packt.Shared;
using static System.Console;

namespace PeopleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // var bob = new Person();
            // bob.Name = "Yang";
            // bob.DateOfBirth = new DateTime(1992,10,10);
            // bob.FavoriteAncientWonder = WondersOfTheAancientWorld.兵马俑;
            // bob.BucketList = WondersOfTheAancientWorld.兵马俑 | WondersOfTheAancientWorld.布达拉宫;
            // bob.Children.Add(new Person {Name="1"});
            // bob.Children.Add(new Person {Name="2"});
            // foreach(var item in bob.Children){
            //     WriteLine($"My Children is {item.Name}");
            // }
            // WriteLine(
            //     format:"{0} was born on {1:dddd,yyyy年MM月dd日},like {2}",
            //     arg0:bob.Name,
            //     arg1:bob.DateOfBirth,
            //     arg2:bob.BucketList
            // );
            // var alice = new Person{
            //     Name = "Li",
            //     DateOfBirth = new DateTime(1992,10,16)
            // };
            //  WriteLine(
            //     format:"{0} was born on {1:dddd,yyyy年MM月dd日}",
            //     arg0:alice.Name,
            //     arg1:alice.DateOfBirth
            // );
            BankAccount.InterestRate = 0.021M;
            var jonesAccount = new BankAccount{
                AccountName = "Mrs.Yang",
                Balance = 2400
            };
             var gerrieAccount = new BankAccount{
                AccountName = "Mrs.Li",
                Balance = 1000
            };
             WriteLine(
                format:"{0} earned {1:C} interest",
                arg0:jonesAccount.AccountName,
                arg1:jonesAccount.Balance * BankAccount.InterestRate
            );
            WriteLine(
                format:"{0} earned {1:C} interest",
                arg0:gerrieAccount.AccountName,
                arg1:gerrieAccount.Balance * BankAccount.InterestRate
            );
        } 
    }
}
