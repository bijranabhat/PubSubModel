using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PublisherSubscribeModel
{
    class PublisherAppLogs
    {


        public void AppLogs()
        {


            string eventLogName = "Application";

            EventLog eventLog = new EventLog();
            eventLog.Log = eventLogName;

            foreach (EventLogEntry log in eventLog.Entries)
            {
                Console.WriteLine("{0}\n", log.Message);
            }


        }


    }
}
