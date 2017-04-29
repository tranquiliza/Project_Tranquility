using Project_Tranquility.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Data
{
    public class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
