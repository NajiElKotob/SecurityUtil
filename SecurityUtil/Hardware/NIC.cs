using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DotNETHeroes.SecurityUtil.Hardware
{
    public static class NIC
    {
        /// <summary>
        /// Provides information about the NIC.
        /// </summary>
        /// <remarks>
        /// NetworkInterface Class (Provides configuration and statistical information for a network interface)
        /// https://msdn.microsoft.com/en-us/library/system.net.networkinformation.networkinterface(v=vs.110).aspx
        /// </remarks>
        /// <returns></returns>
        public static string[] MacAddresses()
        {
            List<string> macAddresses = new List<string>();

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            if (networkInterfaces != null || networkInterfaces.Length > 0)
            {
                foreach (NetworkInterface adapter in networkInterfaces)
                {
                    macAddresses.Add(Converter.BytesConverter.BytesToHex(adapter.GetPhysicalAddress().GetAddressBytes()));
                }
            }
            else
            {
                return null;
            }

            return macAddresses.ToArray();
        }
    }
}

