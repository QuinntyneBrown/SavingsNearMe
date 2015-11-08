using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data.Contracts;
using SavingsNearMeApi.Models;

namespace SavingsNearMeApi.Data.Contracts
{
    public interface ISavingsNearMeUow: IUow
    {
        IRepository<Coupon> Coupons { get; }
        void SaveChanges();
    }
}
