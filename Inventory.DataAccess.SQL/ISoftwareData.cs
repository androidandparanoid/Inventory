using Inventory.Core.Models;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public interface ISoftwareData
    {
        IEnumerable<TblSoftware> GetAll();
        IEnumerable<TblSoftware> GetSoftwareByName(string name);
    }


}
