using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.EmployeeService
{
  public  interface IEmployeeService
    {
        IEnumerable<Trakify_Employee> GetEmployees();
        Trakify_Employee GetEmployee(long id);
        void InsertEmployee(Trakify_Employee employee);
        void UpdateEmployee(Trakify_Employee employee);
        void DeleteEmployee(long id);
    }
}
