#nullable enable
using System;

namespace Arrays
{
    class Address{
        public  string? Building;
        public  string Street = string.Empty;
        public  string City = string.Empty;
        public  string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // string[] names;
            // names = new string[4];
            // names[0] = "Kate";
            // names[1] = "Jack";
            // names[2] = "Rebecca";
            // names[3] = "Tom";

            // for(int i = 0;i < names.Length;i++)
            // {
            //  Console.WriteLine(names[i]);   
            // }
            //C#8.0新特性，引用类型可空
            var address = new Address();
            address.Building = null;
            //address.Street = null;
            address.City = "London";
            //address.Region = null;
            Console.WriteLine(address.Building);
            //Console.WriteLine(address.Street);
            Console.WriteLine(address.City);
            //Console.WriteLine(address.Region);

            string ?authorName = null;
            int ?y = authorName?.Length;
            int ?z = authorName?.Length ?? 3;
            Console.WriteLine(y);
            Console.WriteLine(z);
       }
    }
}
