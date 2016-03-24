using System;
using System.Collections.Generic;
using System.Linq;
using RAD302_S00144297.Models.DTO;
using RAD302_S00144297.Models;
using System.Data.Entity;
using RAD302_S00144297;

namespace RAD302_S00144297.DAL
{
    public class EmployeeRepository : IRepository<EmployeeDetail>
    {
        SampleDBEntities db;
        

        public EmployeeRepository(SampleDBEntities db)
        {
            this.db = db;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDetail> GetAllItems()
        {
            var employees = db.Employees.ToList();
            //mapping
           var mapper = AutoMapperConfigurations.Configuration.CreateMapper();

            return mapper.Map<List<EmployeeDetail>>(employees);
        }

        public EmployeeDetail GetItemByID(int id)
        {
            var employee = db.Employees.Include(em => em.Territories).FirstOrDefault(em => em.EmployeeID == id);

            //mapping
            var mapper = AutoMapperConfigurations.Configuration.CreateMapper();

            return mapper.Map<EmployeeDetail>(employee);
        }

        public List<EmployeeDetail> GetAllEmployeesInTerritory(string territoryID)
        {
            List<Employee> employees = new List<Employee>();

            foreach (var emp in db.Employees.Include(em => em.Territories))

                if (emp.Territories.Any(t => t.TerritoryID == territoryID))
                    employees.Add(emp);

            var mapper = AutoMapperConfigurations.Configuration.CreateMapper();
            return mapper.Map<List<EmployeeDetail>>(employees);
        }
    }
}
