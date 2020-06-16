using Inventory.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Inventory.DataAccess.InMemory
{
    public interface IHardwareData
    {
        //Before SearchByName
        //IEnumerable<HardwareInventory> GetAll();
        IEnumerable<HardwareInventory> GetHardwareByName(string name);
        HardwareInventory GetHardwareById(string id);

        HardwareInventory Update(HardwareInventory hardwareInventory);
        HardwareInventory Add(HardwareInventory hardwareInventory);
        int Commit();
    }
    public class InMemoryHardwareData : IHardwareData
    {
        readonly List<HardwareInventory> hardwareInventories;

        public InMemoryHardwareData()
        {
            hardwareInventories = new List<HardwareInventory>()
            {
                new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "AD3",
                    Location = HardwareInventory.HDLocation.Portable_VM,
                    IPAddress = "10.10.10.20",
                    MacAddress = "00-FF-A0-C6-B7-72",
                    DHCPServer = "1",
                    DNSServer = "10.10.10.20",
                    UserName = "DFWU\\Administrator",
                    DomainMember = true,
                    Domain = "dfwu.local",
                    OSVersion = "10.0.14393",
                    OSBuild = "14393",
                    OSArchitecture = "64 bits",
                    OSInstallDate = "2017-05-29",
                    LastUpdated = "2017-05-29",
                    RemoteDesktop = "Enabled",
                    TimeZone = "(UTC-06:00) Guadalajara, Mexico City, Monterrey",
                    ChassisType = HardwareInventory.HDType.Server,
                    OperatingSystem = "Server 2016",
                    SerialNumber = "VMware-56 4d 3f 59 e1 8f 20 41-cb 5d 6d 94 58 6c 86 88",
                    Model = "VMware Virtual Platform",
                    Manufacturer = "VMware, Inc.",
                    RAM_MB = "2048",
                    DiskSize_GB = "60 GB",
                    Processor = "Intel(R) Core(TM) i7-7600U CPU @ 2.80GHz",
                    Sockets = "1",
                    Cores = "2",
                    SystemType = "x64-based PC",
                    FirmwareVersion = "A18",
                    Scanned = true,
                    ScanDate = Convert.ToDateTime("2018-06-04")



                },
                 new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "DESKTOP-4MJNR0T",
                    Location = HardwareInventory.HDLocation.Portable_Computer,
                    IPAddress = "10.10.10.20",
                    MacAddress = "00-FF-A0-C6-B7-72",
                    DHCPServer = "Static Address",
                    DNSServer = "10.10.10.20",
                    UserName = "DFWU\\Administrator",
                    DomainMember = true,
                    Domain = "dfwu.local",
                    OSVersion = "10.0.14393",
                    OSBuild = "14393",
                    OSArchitecture = "64 bits",
                    OSInstallDate = "2017-05-29",
                    LastUpdated = "2017-05-29",
                    RemoteDesktop = "Enabled",
                    TimeZone = "(UTC-06:00) Guadalajara, Mexico City, Monterrey",
                    ChassisType = HardwareInventory.HDType.Laptop,
                    OperatingSystem = "Windows 10",
                    SerialNumber = "5CG7171VMT",
                    Model = "VMware Virtual Platform",
                    Manufacturer = "VMware, Inc.",
                    RAM_MB = "2048",
                    DiskSize_GB = "60 GB",
                    Processor = "Intel(R) Core(TM) i7-7600U CPU @ 2.80GHz",
                    Sockets = "1",
                    Cores = "2",
                    SystemType = "x64-based PC",
                    FirmwareVersion = "A18",
                    Scanned = true,
                    ScanDate = Convert.ToDateTime("2018-06-04")

                },
                  new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "W7",
                    Location = HardwareInventory.HDLocation.Home_Server,
                    IPAddress = "10.10.10.20",
                    MacAddress = "00-FF-A0-C6-B7-72",
                    DHCPServer = "10.10.10.20",
                    DNSServer = "10.10.10.20",
                    UserName = "DFWU\\Administrator",
                    DomainMember = true,
                    Domain = "dfwu.local",
                    OSVersion = "10.0.14393",
                    OSBuild = "14393",
                    OSArchitecture = "64 bits",
                    OSInstallDate = "2017-05-29",
                    LastUpdated = "2017-05-29",
                    RemoteDesktop = "Enabled",
                    TimeZone = "(UTC-06:00) Guadalajara, Mexico City, Monterrey",
                    ChassisType = HardwareInventory.HDType.Desktop,
                    OperatingSystem = "Windows 7",
                    SerialNumber = "5CG7171VN2",
                    Model = "VMware Virtual Platform",
                    Manufacturer = "VMware, Inc.",
                    RAM_MB = "2048",
                    DiskSize_GB = "60 GB",
                    Processor = "Intel(R) Core(TM) i7-7600U CPU @ 2.80GHz",
                    Sockets = "1",
                    Cores = "2",
                    SystemType = "x64-based PC",
                    FirmwareVersion = "A18",
                    Scanned = true,
                    ScanDate = Convert.ToDateTime("2018-06-04")

                },
                   new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Location = HardwareInventory.HDLocation.Home_Server,
                    IPAddress = "10.10.10.20",
                    MacAddress = "00-FF-A0-C6-B7-72",
                    DHCPServer = "10.10.10.20",
                    DNSServer = "10.10.10.20",
                    UserName = "DFWU\\Administrator",
                    DomainMember = true,
                    Domain = "dfwu.local",
                    OSVersion = "10.0.14393",
                    OSBuild = "14393",
                    OSArchitecture = "64 bits",
                    OSInstallDate = "2017-05-29",
                    LastUpdated = "2017-05-29",
                    RemoteDesktop = "Enabled",
                    TimeZone = "(UTC-06:00) Guadalajara, Mexico City, Monterrey",
                    ChassisType = HardwareInventory.HDType.Server,
                    OperatingSystem = "Server 2012 R2",
                    SerialNumber = "5CG7171VNJ",
                    Model = "VMware Virtual Platform",
                    Manufacturer = "VMware, Inc.",
                    RAM_MB = "2048",
                    DiskSize_GB = "60 GB",
                    Processor = "Intel(R) Core(TM) i7-7600U CPU @ 2.80GHz",
                    Sockets = "1",
                    Cores = "2",
                    SystemType = "x64-based PC",
                    FirmwareVersion = "A18",
                    Scanned = true,
                    ScanDate = Convert.ToDateTime("2018-06-04")

                }


            };
        }

        public HardwareInventory GetHardwareById(string id)
        {
            return hardwareInventories.SingleOrDefault(h => h.HDId == id);
        }

        public IEnumerable<HardwareInventory> GetHardwareByName(string name = null)                      
        {
            return from h in hardwareInventories
                   where string.IsNullOrEmpty(name) || h.HostName.Contains(name, StringComparison.CurrentCultureIgnoreCase) 
                   || h.Location.ToString().Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || h.OperatingSystem.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || h.ChassisType.ToString().Contains(name,StringComparison.CurrentCultureIgnoreCase)
                   orderby h.HostName
                   select h;
        }

        public HardwareInventory Update(HardwareInventory updatedHardwareInventory)
        {
            var hardwareInventory = hardwareInventories.SingleOrDefault(h => h.HDId == updatedHardwareInventory.HDId);

            if(hardwareInventory != null)
            {
                hardwareInventory.Location = updatedHardwareInventory.Location;
            }
            return hardwareInventory;
        }

        public HardwareInventory Add(HardwareInventory newHardwareInventory)
        {
            hardwareInventories.Add(newHardwareInventory);

            newHardwareInventory.HDId = Guid.NewGuid().ToString();

            return newHardwareInventory;
        }
              

        //public IEnumerable<HardwareInventory> GetAll()
        //{
        //    return from h in hardwareInventories
        //           orderby h.HostName
        //           select h;
        //}
        public int Commit()
        {
            return 0;
        }
    }

    
}
