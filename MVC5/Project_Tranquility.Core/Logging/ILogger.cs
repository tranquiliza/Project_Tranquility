using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Logging
{
    public interface ILogger
    {
        void Log(string message);
        void Log(Exception ex);
    }
}
