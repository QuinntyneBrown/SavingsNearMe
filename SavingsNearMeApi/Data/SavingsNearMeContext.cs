﻿using System.Data.Entity;
using Common.Data.Contracts;
﻿using SavingsNearMeApi.Data.Contracts;
﻿using SavingsNearMeApi.Models;

namespace SavingsNearMeApi.Data
{
    public class SavingsNearMeContext : DbContext, ISavingsNearMeContext
    {
        public SavingsNearMeContext()
            : base(nameOrConnectionString: "savingsNearMe")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;

        }

        public DbSet<Coupon> Coupons { get; set; }


    }
}