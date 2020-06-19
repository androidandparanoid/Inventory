using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public interface IWarrantyData
    {
        IEnumerable<WarrantyInformation> GetAll();
        IEnumerable<WarrantyInformation> GetWarrantyByAsset(string name);
        WarrantyInformation GetWarrantyBySerial(string name);
        int GetCountOfWarranty();
        int Commit();
    }
}
