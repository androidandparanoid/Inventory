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
        IEnumerable<SoftwareInventory> GetSoftwareByName(string name);
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
                },
                 new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Program = "Program1",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                 new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Program = "Program2",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                  new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Program = "Program3",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                   new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Program = "Program4",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                },
                    new SoftwareInventory
                {
                    SoftID = Guid.NewGuid().ToString(),
                    HostName = "BOX",
                    Program = "Program5",
                    Version = "1.9",
                    Publisher = "Microsoft",
                    InstallDate = "20/20/2020"
                }
            };


        }

        public IEnumerable<SoftwareInventory> GetSoftwareByName(string name = null)
        {
            return from s in softwareInventories
                   where string.IsNullOrEmpty(name) || s.HostName.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || s.Program.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || s.Version.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || s.Publisher.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   orderby s.HostName
                   select s;
        }

        public IEnumerable<SoftwareInventory> GetAll()
        {
            return from h in softwareInventories
                   orderby h.HostName
                   select h;
        }


    }


}
