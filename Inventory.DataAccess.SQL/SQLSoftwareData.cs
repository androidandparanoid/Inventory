using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Inventory.DataAccess.SQL
{
    public class SQLSoftwareData : ISoftwareData
    {
        private readonly DeploymentsContext db;

        public SQLSoftwareData(DeploymentsContext db)
        {            
            this.db = db;
        }

        public IEnumerable<TblSoftware> GetSoftwareByName(string name = null)
        {           
            return from s in db.TblSoftware
                   where string.IsNullOrEmpty(name) || s.ComputerName.ToLower().Contains(name)
                   || s.Program.ToLower().Contains(name)
                   || s.Version.ToLower().Contains(name)
                   || s.Publisher.ToLower().Contains(name)
                   orderby s.ComputerName
                   select s;
        }

        public IEnumerable<TblSoftware> GetAll()
        {
            return from h in db.TblSoftware
                   orderby h.ComputerName
                   select h;
        }

    }


}
