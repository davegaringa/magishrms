using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(Guid employeeId);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee dbEmployee, Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
