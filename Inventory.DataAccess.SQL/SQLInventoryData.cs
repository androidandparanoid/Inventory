using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Inventory.DataAccess.SQL
{
    public class SQLHardwareInventoryData : IHardwareData
    {
        private readonly DataContext db;

        public SQLHardwareInventoryData(DataContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
        public HardwareInventory Add(HardwareInventory hardwareInventory)
        {
            throw new NotImplementedException();
        }      

        public HardwareInventory Delete(string id)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfHardware()
        {
            throw new NotImplementedException();
        }

        public HardwareInventory GetHardwareById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HardwareInventory> GetHardwareByName(string name)
        {
            var query = from h in db.HardwareInventory
                        where string.IsNullOrEmpty(name) || h.HostName.ToLower().Contains(name)
                        || h.Location.ToString().ToLower().Contains(name)
                        || h.OperatingSystem.ToLower().Contains(name)
                        || h.ChassisType.ToString().ToLower().Contains(name)
                        orderby h.HostName
                        select h;
            return query;
        }

        public HardwareInventory Update(HardwareInventory hardwareInventory)
        {
            throw new NotImplementedException();
        }
    }

    public class SQLSoftwareInventoryData : ISoftwareData
    {
        private readonly DataContext db;

        public SQLSoftwareInventoryData(DataContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public IEnumerable<SoftwareInventory> GetAll()
        {
            var query = from s in db.SoftwareInventory
                        orderby s.HostName
                        select s;
            return query;
        }

        public int GetCountOfSoftware()
        {
            return db.SoftwareInventory.Count();
        }

        public IEnumerable<SoftwareInventory> GetSoftwareByName(string name)
        {
            var query = from s in db.SoftwareInventory
                        where string.IsNullOrEmpty(name) || s.HostName.ToLower().Contains(name)
                        || s.Program.ToLower().Contains(name)
                        || s.Version.ToLower().Contains(name)
                        || s.Publisher.ToLower().Contains(name)
                        orderby s.HostName
                        select s;
            return query;
        }
    }

    public class SQLWarrantyInventoryData : IWarrantyData
    {
        public int Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WarrantyInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetCountOfWarranty()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WarrantyInformation> GetWarrantyByAsset(string name)
        {
            throw new NotImplementedException();
        }

        public WarrantyInformation GetWarrantyBySerial(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class SQLSoftwareScanInventoryData : ISoftwareScanData
    {
        public SoftwareScan Add(SoftwareScan softwareScan)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public SoftwareScan Delete(string id)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfSoftwareScan()
        {
            throw new NotImplementedException();
        }

        public SoftwareScan Update(SoftwareScan softwareScan)
        {
            throw new NotImplementedException();
        }
    }
}
