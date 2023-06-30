using DEMO_PROJECT_C2108G3_Delivery.Data;
using DEMO_PROJECT_C2108G3_Delivery.Models;

namespace DEMO_PROJECT_C2108G3_Delivery.Repository
{
	public interface IPostalServiceRepository : IBaseRepository<PostalService>
	{
		public void THongKeSoLuongHang();
		public void LinhTinhTheoNghiepVu(DateTime startDate, DateTime endDate);
	}
	public class PostalServiceRepository : BaseRepository<PostalService>, IPostalServiceRepository
	{
        public PostalServiceRepository(ApplicationDbContext context) : base (context)
        {
            
        }

		public void LinhTinhTheoNghiepVu(DateTime startDate, DateTime endDate)
		{
			throw new NotImplementedException();
		}

		public void THongKeSoLuongHang()
		{
			throw new NotImplementedException();
		}
	}
}
