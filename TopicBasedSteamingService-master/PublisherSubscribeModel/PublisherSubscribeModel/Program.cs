using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PublisherSubscribeModel
{
    class Program
    {
        static void Main(string[] args)
        {

           PublisherSysLogs logs = new PublisherSysLogs();
            PublisherAppLogs logs1 = new PublisherAppLogs();
            logs1.AppLogs();
            logs.SysLogs();

        }
    }
}
