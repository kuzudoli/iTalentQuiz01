using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal interface ILogger
    {
        void WriteLog();
    }

    internal class DBLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("DB logger executed!");
        }
    }

    internal class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("File logger executed!");
        }
    }
    internal class LoggerBLL
    {
        private ILogger _logger;
        public LoggerBLL(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
