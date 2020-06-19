using Inventory.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public interface IHardwareData
    {
        IEnumerable<HardwareInventory> GetHardwareByName(string name);
        HardwareInventory GetHardwareById(string id);
        HardwareInventory Update(HardwareInventory hardwareInventory);
        HardwareInventory Add(HardwareInventory hardwareInventory);
        HardwareInventory Delete(string id);
        int GetCountOfHardware();
        int Commit();
    }
}
