using DEMO_PROJECT_C2108G3_Delivery.Data;
using DEMO_PROJECT_C2108G3_Delivery.Models;
using DEMO_PROJECT_C2108G3_Delivery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DEMO_PROJECT_C2108G3_Delivery.Controllers
{
	public class PostalServicesController : BaseController<PostalService>
	{
		private IPostalServiceRepository _postalServiceRepository;
	
        public PostalServicesController(IPostalServiceRepository postalServiceRepository, ApplicationDbContext applicationDbContext, IBaseRepository<PostalService> baseRepository) 
			: base (baseRepository, applicationDbContext)
        {
            _postalServiceRepository = postalServiceRepository;
			
        }

		public IActionResult Index()
		{
			
			return View();
		}
        
	}

}
