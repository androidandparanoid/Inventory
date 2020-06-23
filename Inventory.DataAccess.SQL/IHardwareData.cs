using Inventory.Core.Models;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Inventory.DataAccess.SQL
{
    public interface IHardwareData
    {
        //Before SearchByName
        //IEnumerable<HardwareInventory> GetAll();
        IEnumerable<TblInventory> GetHardwareByName(string name);
        TblInventory GetHardwareById(int id);

        TblInventory Update(TblInventory hardwareInventory);
        TblInventory Add(TblInventory hardwareInventory);
        int Commit();
    }


}
