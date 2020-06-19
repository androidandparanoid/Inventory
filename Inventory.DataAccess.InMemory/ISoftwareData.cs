using Inventory.Core.Models;
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
