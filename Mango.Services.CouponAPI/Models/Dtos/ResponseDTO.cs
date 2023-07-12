using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Diagnostics.Eventing.Reader;

namespace Mango.Services.CouponAPI.Models.Dtos
{
    public class ResponseDTO
    {
        public object? Result { get; set; }

        public bool IsSuccess { get; set; } = true;

        public string Message { get; set; } = "";
    }
}
