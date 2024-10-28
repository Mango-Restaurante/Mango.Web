using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
	public class CouponService : ICouponService
	{
		private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
			_baseService = baseService;
        }

		//antes de implementar los metodos, agregar la iny de dependencias (Program.cs)

        public Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
		{
			
		}

		public Task<ResponseDto?> DeleteCouponsAsync(int id)
		{
			
		}

		public Task<ResponseDto?> GetAllCouponsAsync()
		{
			
		}

		public Task<ResponseDto?> GetCouponAsync(string couponCode)
		{
			
		}

		public Task<ResponseDto?> GetCouponByIdAsync(int id)
		{
			
		}

		public Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
		{
			
		}
	}
}
