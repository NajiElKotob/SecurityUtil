using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace DotNETHeroes.SecurityUtil.Hardware
{
    public static class HardDrive
    {
        public static string VolumeSerialNumber(string driveLetter = "C:")
        {

            /*
            Win32_LogicalDisk class -> https://msdn.microsoft.com/en-us/library/aa394173            
                uint16   Access;
                uint16   Availability;
                uint64   BlockSize;
                string   Caption;
                boolean  Compressed;
                uint32   ConfigManagerErrorCode;
                boolean  ConfigManagerUserConfig;
                string   CreationClassName;
                string   Description;
                string   DeviceID;
                uint32   DriveType;
                boolean  ErrorCleared;
                string   ErrorDescription;
                string   ErrorMethodology;
                string   FileSystem;
                uint64   FreeSpace;
                datetime InstallDate;
                uint32   LastErrorCode;
                uint32   MaximumComponentLength;
                uint32   MediaType;
                string   Name;
                uint64   NumberOfBlocks;
                string   PNPDeviceID;
                uint16   PowerManagementCapabilities[];
                boolean  PowerManagementSupported;
                string   ProviderName;
                string   Purpose;
                boolean  QuotasDisabled;
                boolean  QuotasIncomplete;
                boolean  QuotasRebuilding;
                uint64   Size;
                string   Status;
                uint16   StatusInfo;
                boolean  SupportsDiskQuotas;
                boolean  SupportsFileBasedCompression;
                string   SystemCreationClassName;
                string   SystemName;
                boolean  VolumeDirty;
                string   VolumeName;
                string   VolumeSerialNumber;

            Querying, WHERE Clause
            https://msdn.microsoft.com/en-us/library/aa394054

            */

            //Constant Parameters
            const string VolumeSerialNumber = "VolumeSerialNumber";

            string WMIQuery = $"SELECT * FROM Win32_LogicalDisk WHERE Name = \"{driveLetter}\"";
            string volumeSerialNumber = "NONE";

            foreach (var managementObject in new ManagementObjectSearcher(WMIQuery).Get())
            {
                volumeSerialNumber = managementObject.GetPropertyValue(VolumeSerialNumber).ToString();       
            }

            return volumeSerialNumber;


        }

    }
}
