using Inventory.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inventory.DataAccess.InMemory
{
    public interface ISoftwareData
    {
        IEnumerable<SoftwareInventory> GetAll();
    }
    public class InMemorySoftwareData : ISoftwareData {

        readonly List<SoftwareInventory> softwareInventories;

        public InMemorySoftwareData()
        {
            softwareInventories = new List<SoftwareInventory>()
            {
                new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "AD3",
                    Program = "Program1",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                 new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "AD3",
                    Program = "Program2",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                  new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "AD3",
                    Program = "Program3",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                   new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "AD3",
                    Program = "Program4",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                    new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "AD3",
                    Program = "Program5",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                }
            };


        }

        public IEnumerable<SoftwareInventory> GetAll()
        {
            return from h in softwareInventories
                   orderby h.HostName
                   select h;
        }

    }


}
