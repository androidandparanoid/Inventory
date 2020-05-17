using Inventory.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inventory.DataAccess.InMemory
{
    public interface IHardwareData
    {
        IEnumerable<HardwareInventory> GetAll();
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
                    Location = "Portable VM",
                    Type = HardwareInventory.HDType.Server,
                    OperatingSystem = "Server 2016"

                },
                 new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "DESKTOP-4MJNR0T",
                    Location = "Portable Computer",
                    Type = HardwareInventory.HDType.Laptop,
                    OperatingSystem = "Windows 10"

                },
                  new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "W7",
                    Location = "HOME Server",
                    Type = HardwareInventory.HDType.Desktop,
                    OperatingSystem = "Windows 7"

                },
                   new HardwareInventory
                {
                    HDId = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Location = "HOME Server",
                    Type = HardwareInventory.HDType.Server,
                    OperatingSystem = "Server 2012 R2"

                }


            };
        }

        public IEnumerable<HardwareInventory> GetAll()
        {
            return from h in hardwareInventories
                   orderby h.HostName
                   select h;
        }
    }

    
}
