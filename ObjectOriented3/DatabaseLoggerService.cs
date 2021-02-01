using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
}
