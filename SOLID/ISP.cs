using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal interface IWriteRepository
    {
        void Add(Employee e);
        void Update(int id, Employee e);
        void Delete(int id);
    }
    internal interface IReadRepository
    {
        Employee GetById(int id);
        List<Employee> GetAll();
    }

    internal class EmployeeRepository : IWriteRepository, IReadRepository
    {
        public List<Employee> Employees;
        public EmployeeRepository()
        {
            Employees = new();
        }
        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        public void Delete(int id)
        {
            int index = Employees.FindIndex(e => e.Id == id);
            Employees.RemoveAt(index);
        }
        public void Update(int id, Employee employee)
        {
            var eIndex = Employees.FindIndex(e => e.Id == id);
            Employees[eIndex] = employee;
        }

        public List<Employee> GetAll()
        {
            return Employees;
        }

        public Employee GetById(int id)
        {

            return Employees.First(e => e.Id == id);
        }
    }
}
