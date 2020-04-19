using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            Create(employee);
            Save();
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
            Save();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return FindAll()
                .OrderBy(ow => ow.LastName);
        }

        public Employee GetEmployeeById(Guid employeeId)
        {
            return FindByCondition(employee => employee.Id.Equals(employeeId))
                    .DefaultIfEmpty(new Employee())
                    .FirstOrDefault();
        }

        public void UpdateEmployee(Employee dbEmployee, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
