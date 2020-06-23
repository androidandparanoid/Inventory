using Inventory.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Inventory.DataAccess.SQL
{
    public class SQLHardwareData : IHardwareData
    {
        private readonly DeploymentsContext db;

        public SQLHardwareData(DeploymentsContext db)
        {
            this.db = db;
        }
      
        public TblInventory GetHardwareById(int id)
        {
            return db.TblInventory.SingleOrDefault(h => h.Id == id);
        }

        public IEnumerable<TblInventory> GetHardwareByName(string name = null)
        {           
            return from h in db.TblInventory
                   where string.IsNullOrEmpty(name) || h.ComputerName.ToLower().Contains(name)
                   || h.Location.ToLower().Contains(name)
                   || h.OperatingSystem.ToLower().Contains(name)
                   || h.ChassisType.ToLower().Contains(name)
                   orderby h.ComputerName
                   select h;
        }

        public TblInventory Update(TblInventory updatedHardwareInventory)
        {
            var hardwareInventory = db.TblInventory.SingleOrDefault(h => h.Id == updatedHardwareInventory.Id);

            if (hardwareInventory != null)
            {
                hardwareInventory.Location = updatedHardwareInventory.Location;
            }
            return hardwareInventory;
        }

        public TblInventory Add(TblInventory newHardwareInventory)
        {
            db.TblInventory.Add(newHardwareInventory);

            //newHardwareInventory.Id = Guid.NewGuid().ToString();

            return newHardwareInventory;
        }

        public int Commit()
        {
            return 0;
        }
    }


}
