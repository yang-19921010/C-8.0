using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : Object
    {
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAancientWorld FavoriteAncientWonder;

        public WondersOfTheAancientWorld BucketList;

        //子女信息
        public List<Person> Children = new List<Person>();
    }

}
