using Inventory.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public interface IDellWarrantyData
    {
        IEnumerable<TblDellWarranty> GetAll();
        IEnumerable<TblDellWarranty> GetWarrantyByAsset(string name);
        TblDellWarranty GetWarrantyBySerial(string name);
    }
}
