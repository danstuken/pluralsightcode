
namespace EmployeeManager.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using EmployeeManager.Domain;

    public class DepartmentController : Controller
    {
        private readonly DepartmentDataSource _db;

        public DepartmentController(DepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Detail(int id)
        {
            var model = _db.Departments.Single(d => d.Id == id);
            return View(model);
        }

    }
}
