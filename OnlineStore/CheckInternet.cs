using System;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace OnlineStore
{
    class CheckInternet
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);
        [Flags]

        enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }

        public static bool CheckForInternetConnection_Wininet()
        {
            InternetConnectionState flags = 0;
            if (InternetGetConnectedState(ref flags, 0) == true)
                return true;
            else
                return false;
        }

        public static bool CheckForInternetConnection_Ping()
        {
            try
            {
                Ping pingObj = new Ping();
                PingOptions pingOption = new PingOptions();
                byte[] buffer = new byte[32];
                PingReply reply = pingObj.Send("8.8.8.8", 1000, buffer, pingOption); // ping google directly through IP
                if (reply.Status == IPStatus.Success)
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
