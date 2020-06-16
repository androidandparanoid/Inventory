using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inventory.DataAccess.InMemory
{
    public interface IWarrantyData
    {
        IEnumerable<WarrantyInformation> GetAll();
        IEnumerable<WarrantyInformation> GetWarrantyByAsset(string name);
        WarrantyInformation GetWarrantyBySerial(string name);
    }

    public class InMemoryWarrantyData : IWarrantyData
    {
        readonly List<WarrantyInformation> warrantyInformation;

        public InMemoryWarrantyData()
        {
            warrantyInformation = new List<WarrantyInformation>()
            {
                new WarrantyInformation
                {
                    WarrantyID = Guid.NewGuid().ToString(),
                    AssetTag = "VMware-56 4d 3f 59 e1 8f 20 41-cb 5d 6d 94 58 6c 86 88",
                    Model = "Latitude 7490",
                    ModelFamily = "Latitude",
                    ProductId = "latitude-14-7490-laptop",
                    WarrantyStartDate = Convert.ToDateTime("2019-07-17 00:00:00.000"),
                    WarrantyEndDate = Convert.ToDateTime("2021-12-02 23:59:59.000"),
                    Checked = false,
                    ScanDate = Convert.ToDateTime("2019-09-18"),
                    WarrantyDaysLeft = 802,
                    WarrantyMonthsLeft = 26,
                    WarrantyYearsLeft = 2,
                    Status = WarrantyInformation.WarrantyStatus.VALID,
                    Memory = "16GB 2400 MHz 2RX8 DDR4",
                    Storage = "SSDR 256 GB"

                },
                new WarrantyInformation
                {
                    WarrantyID = Guid.NewGuid().ToString(),
                    AssetTag = "5CG7171VMT",
                    Model = "Latitude 7490",
                    ModelFamily = "Latitude",
                    ProductId = "latitude-14-7490-laptop",
                    WarrantyStartDate = Convert.ToDateTime("2019-07-17 00:00:00.000"),
                    WarrantyEndDate = Convert.ToDateTime("2021-12-02 23:59:59.000"),
                    Checked = true,
                    ScanDate = Convert.ToDateTime("2019-09-18"),
                    WarrantyDaysLeft = 802,
                    WarrantyMonthsLeft = 26,
                    WarrantyYearsLeft = 2,
                    Status = WarrantyInformation.WarrantyStatus.WARNING,
                    Memory = "16GB 2400 MHz 2RX8 DDR4",
                    Storage = "SSDR 256 GB"

                },
                new WarrantyInformation
                {
                    WarrantyID = Guid.NewGuid().ToString(),
                    AssetTag = "5CG7171VN2",
                    Model = "Latitude 7490",
                    ModelFamily = "Latitude",
                    ProductId = "latitude-14-7490-laptop",
                    WarrantyStartDate = Convert.ToDateTime("2019-07-17 00:00:00.000"),
                    WarrantyEndDate = Convert.ToDateTime("2021-12-02 23:59:59.000"),
                    Checked = true,
                    ScanDate = Convert.ToDateTime("2019-09-18"),
                    WarrantyDaysLeft = 802,
                    WarrantyMonthsLeft = 26,
                    WarrantyYearsLeft = 2,
                    Status = WarrantyInformation.WarrantyStatus.EXPIRED,
                    Memory = "16GB 2400 MHz 2RX8 DDR4",
                    Storage = "SSDR 256 GB"

                },
                new WarrantyInformation
                {
                    WarrantyID = Guid.NewGuid().ToString(),
                    AssetTag = "5CG7171VNJ",
                    Model = "Latitude 7490",
                    ModelFamily = "Latitude",
                    ProductId = "latitude-14-7490-laptop",
                    WarrantyStartDate = Convert.ToDateTime("2019-07-17 00:00:00.000"),
                    WarrantyEndDate = Convert.ToDateTime("2021-12-02 23:59:59.000"),
                    Checked = true,
                    ScanDate = Convert.ToDateTime("2019-09-18"),
                    WarrantyDaysLeft = 802,
                    WarrantyMonthsLeft = 26,
                    WarrantyYearsLeft = 2,
                    Status = WarrantyInformation.WarrantyStatus.VALID,
                    Memory = "16GB 2400 MHz 2RX8 DDR4",
                    Storage = "SSDR 256 GB"

                }
            };
        }

        public IEnumerable<WarrantyInformation> GetWarrantyByAsset(string name = null)
        {
            return from w in warrantyInformation
                   where string.IsNullOrEmpty(name) || w.AssetTag.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || w.Model.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   || w.Status.ToString().Contains(name, StringComparison.CurrentCultureIgnoreCase)
                   orderby w.AssetTag
                   select w;
        }

        public WarrantyInformation GetWarrantyBySerial(string name)
        {
            return warrantyInformation.SingleOrDefault(w => w.AssetTag == name);
        }

        public IEnumerable<WarrantyInformation> GetAll()
        {
            return from w in warrantyInformation
                   orderby w.AssetTag
                   select w;
        }
    }
}
