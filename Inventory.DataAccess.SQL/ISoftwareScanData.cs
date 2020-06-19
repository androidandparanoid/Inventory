using Inventory.Core.Models;

namespace Inventory.DataAccess.SQL
{
    public interface ISoftwareScanData
    {
        SoftwareScan Update(SoftwareScan softwareScan);
        SoftwareScan Add(SoftwareScan softwareScan);
        SoftwareScan Delete(string id);
        int GetCountOfSoftwareScan();
        int Commit();
    }
}