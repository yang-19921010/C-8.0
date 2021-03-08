using System;
using System.Linq;
using System.Reflection;

namespace Repos
{
    class Program
    {
        static void Main(string[] args)
        {
        //  Console.WriteLine("Hello C#！");
        #region   揭示C#词汇表的范围
        // System.Data.DataSet ds;
        // System.Net.Http.HttpClient client;
        // //GetEntryAssembly()：获取已加载的程序集；GetReferencedAssemblies()：获取此程序集引用的所有程序集的AssemblyName对象
        // foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()){
        //     //加载程序集以便我们可以读取其详细信息
        //     var a = Assembly.Load(new AssemblyName(r.FullName));
        //     //声明一个变量来计算方法的数量
        //     int methodCount = 0;
        //     //遍历程序集中的所有类型
        //     foreach(var t in a.DefinedTypes){
        //         methodCount += t.GetMethods().Count();
        //     }
        //     Console.WriteLine(
        //         "{0:N0} 类型 {1:N0} 方法 {2} 程序集",
        //         arg0:a.DefinedTypes.Count(),
        //         arg1:methodCount,
        //         arg2:r.Name
        //     );
        //    }
        #endregion;
        #region   使用变量
        double heightInMetres = 1.88;
        Console.WriteLine($"变量 { (heightInMetres)} 对应的值 {heightInMetres}");
        #endregion

        }
    }
}
