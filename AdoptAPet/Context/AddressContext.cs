using AdoptAPet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdoptAPet.Context
{
    public class AddressContext: DbContext
    {
        public DbSet<Address> Addresses { get; set; }

      
    }
}