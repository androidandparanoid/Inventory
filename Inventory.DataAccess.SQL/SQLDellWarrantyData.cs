using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.DataAccess.SQL
{
    public class SQLDellWarrantyData : IDellWarrantyData
    {
        private readonly DeploymentsContext db;

        public SQLDellWarrantyData(DeploymentsContext db)
        {
            this.db = db;
        }

        public IEnumerable<TblDellWarranty> GetWarrantyByAsset(string name = null)
        {

            return from w in db.TblDellWarranty
                   where string.IsNullOrEmpty(name) || w.AssetTag.ToLower().Contains(name)
                   || w.Model.ToLower().Contains(name)
                   || w.WarrantyStatus.ToLower().Contains(name)
                   orderby w.AssetTag
                   select w;
        }

        public TblDellWarranty GetWarrantyBySerial(string name)
        {
            return db.TblDellWarranty.SingleOrDefault(w => w.AssetTag == name);
        }

        public IEnumerable<TblDellWarranty> GetAll()
        {
            return from w in db.TblDellWarranty
                   orderby w.AssetTag
                   select w;
        }
    }
}
