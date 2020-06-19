using Inventory.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public interface ISoftwareData
    {
        IEnumerable<SoftwareInventory> GetAll();
        IEnumerable<SoftwareInventory> GetSoftwareByName(string name);
        int GetCountOfSoftware();
        int Commit();
    }
}
