using System;

namespace ObjectOriented3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}