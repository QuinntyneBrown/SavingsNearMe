using Common.Controllers;
using SavingsNearMeApi.Data.Contracts;
using SavingsNearMeApi.Models;

namespace SavingsNearMeApi.Controllers
{
    public class CouponController : EFController<Coupon>
    {
        public CouponController(ISavingsNearMeUow uow)
        {
            base.uow = uow;
            base.repository = uow.Coupons;
        }
    }
}
