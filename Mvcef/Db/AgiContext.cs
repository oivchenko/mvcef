using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace Mvcef.Db
{
    public class AgiContext:DbContext
    {
        public DbSet<Employer> Employers { get; set; }
    }
}