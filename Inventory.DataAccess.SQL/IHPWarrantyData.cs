using Inventory.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public interface IHPWarrantyData
    {
        IEnumerable<TblHpwarranty> GetAll();
        IEnumerable<TblHpwarranty> GetWarrantyByAsset(string name);
        TblHpwarranty GetWarrantyBySerial(string name);
    }
}