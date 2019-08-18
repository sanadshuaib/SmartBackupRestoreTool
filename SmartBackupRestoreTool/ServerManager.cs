using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Common;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading;

namespace SmartBackupRestoreTool
{
    public class ServerManager
    {
        DataTable dtServers;

        public ServerManager()
        {
            
        }

        private void EnableSqlBrowserService()
        {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C sc Config SQLBROWSER start= auto";
                process.StartInfo = startInfo;
                process.Start();
        }

        public ServiceControllerStatus CheckSqlBrowserStatus()
        {
            ServiceController oController = new ServiceController("SQL Server Browser");
            if(oController.StartType.Equals(System.ServiceProcess.ServiceStartMode.Disabled))
            {
                EnableSqlBrowserService();
                Thread.Sleep(1000);
            }

            if (oController.Status.Equals(ServiceControllerStatus.Stopped) || oController.Status.Equals(ServiceControllerStatus.Paused))
                oController.Start();

            return oController.Status;
        }

        public void FetchServers()
        {
            dtServers = SmoApplication.EnumAvailableSqlServers(true);
        }

        public List<string> GetServersNames()
        {
            List<string> lstNames = new List<string>();
            // If there are any servers
            if (dtServers.Rows.Count > 0)
            {
                // Loop through each server in the DataTable
                foreach (DataRow drServer in dtServers.Rows)
                {
                    lstNames.Add(drServer["Name"].ToString());
                }
            }

            return lstNames;
        }

        public Server CreateServer(string serverName
            , string userName
            , string password)
        {
            return new Server(new ServerConnection(serverName, userName, password));
        }

        public Server CreateServer(string serverName)
        {
            return new Server(new ServerConnection(serverName));
        }

        public List<string> GetDatabasesNames(Server server)
        {
            List<string> lstNames = new List<string>();

            if(server != null)
            {
                foreach (Database database in server.Databases)
                {
                    lstNames.Add(database.Name);
                }
            }

            return lstNames;
        }
    }
}
