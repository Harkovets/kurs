﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_csh.Entities
{
    public class EFContext: DbContext
    {
        public EFContext():
            base("Connection")
        {

        }
        public DbSet<Worker> Workers { get; set; }
    }
}
