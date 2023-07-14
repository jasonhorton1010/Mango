﻿using Mango.Web.Models;
using Mango.Web.Services.IService;
using Mango.Web.Utility;

namespace Mango.Web.Services
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public async CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDTO> CreateCouponsAsync(CouponDTO couponDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> DeleteCouponsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDTO> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDTO> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDTO> UpdateCouponsAsync(CouponDTO couponDTO)
        {
            throw new NotImplementedException();
        }
    }
}
