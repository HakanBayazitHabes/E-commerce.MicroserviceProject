using BtkAkademi.Services.CouponAPI.Models.Dto;

namespace BtkAkademi.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
