using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository;
using Trakify.Repository.Common;

namespace Trakify.Service.EmployeeService
{
   public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Trakify_Employee> employeeRepository;
        public EmployeeService(IRepository<Trakify_Employee> employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void DeleteEmployee(long id)
        {
            Trakify_Employee employeeProfile = employeeRepository.Get(id);
            employeeRepository.Remove(employeeProfile);
            employeeRepository.SaveChanges();
        }

        public Trakify_Employee GetEmployee(long id)
        {
            return employeeRepository.Get(id);
        }

        public IEnumerable<Trakify_Employee> GetEmployees()
        {
            return employeeRepository.GetAll();
        }

        public void InsertEmployee(Trakify_Employee employee)
        {
            employeeRepository.Insert(employee);
        }

        public void UpdateEmployee(Trakify_Employee employee)
        {
            employeeRepository.Update(employee);
        }
    }
}
