using System.Management;

namespace DotNETHeroes.SecurityUtil.Hardware
{
    public static class Processor
    {
        public static string ProcessorId()
        {
            /*
            Win32_Processor class
            The Win32_Processor WMI class represents a device that can interpret a sequence of 
            instructions on a computer running on a Windows operating system.
            https://msdn.microsoft.com/en-us/library/aa394373(v=vs.85).aspx
            */

            const string processorQuery = "SELECT ProcessorId FROM Win32_Processor";
            const string processorIdColumnName = "ProcessorId";

            string ProcessorId = string.Empty; //Default Value


            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(processorQuery);

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
            {
                ProcessorId = (string)managementObject[processorIdColumnName];
            }

            return (ProcessorId);

        }
    }
}
