using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Email = "john@example.com", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Department = "HR", Salary = 45000 }
        };

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var existing = GetById(employee.Id);
            if (existing != null)
            {
                existing.Name = employee.Name;
                existing.Email = employee.Email;
                existing.Department = employee.Department;
                existing.Salary = employee.Salary;
            }
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}