using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace Virgil
{
    public class ExampleServerSettings : ServerSettingsInterface
    {
        private string serverName;

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        private int serverPort;
        public int ServerPort
        {
            get { return serverPort; }
            set { serverPort = value; }
        }

        private string logFilePath;

        public string LogFilePath
        {
            get { return logFilePath; }
            set { logFilePath = value; }
        }
    }
}
