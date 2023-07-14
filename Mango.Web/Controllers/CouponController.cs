using Mango.Web.Models;
using Mango.Web.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
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

        public async Task<IActionResult> CouponCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CouponCreate(CouponDTO model)
        {
            if(ModelState.IsValid)
            {
                ResponseDTO? response = await _couponService.CreateCouponsAsync(model);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(CouponIndex));
                }
            }

            return View(model); // if model state is not valid return to the view with the model.
        }
    }
}