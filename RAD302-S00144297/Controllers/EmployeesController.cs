using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RAD302_S00144297.Models;
using RAD302_S00144297.DAL;
using RAD302_S00144297.Models.DTO;

namespace RAD302_S00144297.Controllers
{
    public class EmployeesController : ApiController
    {
        private SampleDBEntities db = new SampleDBEntities();

        private EmployeeRepository repo;

        public EmployeesController()
        {
            repo = new EmployeeRepository(new SampleDBEntities());
        }

        public List<EmployeeDetail> GetEmployees()
        {
            return repo.GetAllItems();
        }

        // GET: api/Employees/5
        [ResponseType(typeof(EmployeeDetail))]
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = repo.GetItemByID(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }



        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employees.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeID }, employee);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}