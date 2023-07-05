using DEMO_PROJECT_C2108G3_Delivery.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DEMO_PROJECT_C2108G3_Delivery.ViewComponents
{
    public class SelectBoxPostalService : ViewComponent
    {
        private ApplicationDbContext _context;
        public SelectBoxPostalService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(string cssClass)
        {
            // Xử lý logic và trả về một đối tượng Model cho view
            ViewBag.CSSClass = cssClass;
            var model = _context.PostalServices.ToList(); // Xử lý logic để tạo model

            return View(model); // Trả về view và truyền model vào view
        }
    }
}
