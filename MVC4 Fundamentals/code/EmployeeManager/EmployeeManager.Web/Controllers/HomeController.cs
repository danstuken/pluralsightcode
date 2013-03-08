namespace EmployeeManager.Web.Controllers
{
    using System.Web.Mvc;
    using EmployeeManager.Domain;
    
    public class HomeController : Controller
    {
        private DepartmentDataSource _db;

        public HomeController(DepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;
            return View(allDepartments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
