﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Data;
using Common.Data.Contracts;
﻿using SavingsNearMeApi.Data.Contracts;
﻿using SavingsNearMeApi.Models;

namespace SavingsNearMeApi
{
    public class SavingsNearMeUow : BaseUow, ISavingsNearMeUow
    {
        public SavingsNearMeUow(ISavingsNearMeContext savingsNearMeContext)
            : base(savingsNearMeContext)
        {

        }

        public IRepository<Coupon> Coupons { get { return GetStandardRepo<Coupon>(); } }
    }
}