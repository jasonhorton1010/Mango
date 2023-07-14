﻿using Mango.Web.Models;
using Mango.Web.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class CouponController1 : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController1(ICouponService couponService)
        {
            _couponService = couponService;
        }

        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDTO>? list = new();

            ResponseDTO? response = await _couponService.GetAllCouponsAsync();

            if (response != null && response.IsSuccess) 
            {
                list = JsonConvert.DeserializeObject<List<CouponDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}