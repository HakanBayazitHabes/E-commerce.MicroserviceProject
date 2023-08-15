using BtkAkademi.Services.ShoppingCartAPI.Models.Dto;

namespace BtkAkademi.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
