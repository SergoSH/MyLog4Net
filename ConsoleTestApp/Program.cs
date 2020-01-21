using MyLog4Net;
using System;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            try
            {
                Console.WriteLine("Hello World!");
                Logger.Log.Info("Hello World!");
                throw new Exception("Fucking Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Logger.Log.Error(e.Message);
            }
        }
    }
}
