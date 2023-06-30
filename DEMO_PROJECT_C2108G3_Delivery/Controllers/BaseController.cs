using DEMO_PROJECT_C2108G3_Delivery.Data;
using DEMO_PROJECT_C2108G3_Delivery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DEMO_PROJECT_C2108G3_Delivery.Controllers
{
	public class BaseController<T> : Controller where T: class 
	{
		private IBaseRepository<T> _baseRepository;
		protected ApplicationDbContext _context;
        public BaseController(IBaseRepository<T> baseRepository, ApplicationDbContext context)
        {
			_baseRepository = baseRepository;
			_context = context;
        }
        public virtual IActionResult Index()
		{
			return View();
		}


		public virtual IActionResult Filter(int index = 1, int size = 10, int draw = 1)
		{
			var result = _baseRepository.Filter(null, "Id", false, (index - 1) * size, size, draw);
			return Ok(result);
		}

		public virtual IActionResult ViewCreateOrUpdate()
		{
			return View();
		}

		public IActionResult GetById(int id)
		{
			var result = _baseRepository.GetById(id);
			return result;
		}
		public IActionResult Insert(T entity)
		{
			var result = _baseRepository.Insert(entity);
			return Ok(result); 
		}
		public IActionResult Update(T entity)
		{
			var result = _baseRepository.Update(entity);
			return Ok(result);
		}
		public IActionResult Delete(T entity)
		{
			var result = _baseRepository.Delelte(entity);
			return Ok(result);
		}



	}
}
