using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
           Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
           Trace.AutoFlush = true;
           Trace.WriteLine("I am Trace!");

           //切换跟踪级别
           /*0 Off 不会输出任何东西
             1 Error 只输出错误
             2 Warning 输出错误和警告
             3 Info 输出错误、警告和信息
             4 Verbose 输出所有级别
           */
           var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);
           IConfigurationRoot configuration = builder.Build();
           var ts = new TraceSwitch(displayName:"PacktSwitch",description:"Json config");

           configuration.GetSection("PacktSwitch").Bind(ts);

           Trace.WriteLineIf(ts.TraceError,"error");
           Trace.WriteLineIf(ts.TraceWarning,"warning");
           Trace.WriteLineIf(ts.TraceInfo,"information");
           Trace.WriteLineIf(ts.TraceVerbose,"verbose");
            
        }
    }
}
