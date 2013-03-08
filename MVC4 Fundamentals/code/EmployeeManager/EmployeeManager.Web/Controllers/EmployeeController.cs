namespace EmployeeManager.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using EmployeeManager.Domain;
    using EmployeeManager.Web.Models;

    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly DepartmentDataSource _db;

        public EmployeeController(DepartmentDataSource db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel
                {
                    DepartmentId = departmentId
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.Id == viewModel.DepartmentId);
                var employee = new Employee
                    {
                        Name = viewModel.Name,
                        HireDate = viewModel.HireDate
                    };
                department.Employees.Add(employee);

                _db.Save();
                return RedirectToAction("detail", "Department", new {id = viewModel.DepartmentId});
            }
            return View(viewModel);
        }
    }
}
