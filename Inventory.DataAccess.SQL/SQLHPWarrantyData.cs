using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inventory.DataAccess.SQL
{
    public class SQLHPWarrantyData : IHPWarrantyData
    {
        private readonly DeploymentsContext db;

        public SQLHPWarrantyData(DeploymentsContext db)
        {
            this.db = db;
        }
        public IEnumerable<TblHpwarranty> GetAll()
        {
            return from w in db.TblHpwarranty
                   orderby w.AssetTag
                   select w;
        }

        public IEnumerable<TblHpwarranty> GetWarrantyByAsset(string name)
        {
            return from w in db.TblHpwarranty
                   where string.IsNullOrEmpty(name) || w.AssetTag.ToLower().Contains(name)
                   || w.Model.ToLower().Contains(name)
                   || w.WarrantyStatus.ToLower().Contains(name)
                   orderby w.AssetTag
                   select w;
        }

        public TblHpwarranty GetWarrantyBySerial(string name)
        {
            return db.TblHpwarranty.SingleOrDefault(w => w.AssetTag == name);
        }
    }
}
