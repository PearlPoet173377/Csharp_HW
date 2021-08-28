using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loger
{
    class Program
    {
        static void Main(string[] args)
        {
            Loger loger = new Loger("Loger.txt", "Config.ini");
            loger.CreateLog("Test message", "User_1", "123");
            loger.GetLogs();
        }
    }
}