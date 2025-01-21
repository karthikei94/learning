using System.Collections.Generic;
using cqrs_memento_app.Domain.Interfaces;

namespace cqrs_memento_app.Infrastructure.Persistence
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Dictionary<int, List<Employee>> _history = new Dictionary<int, List<Employee>>();
        private readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();

        public void Save(Employee employee)
        {
            _employees[employee.Id] = employee;
        }

        public Employee Retrieve(int id)
        {
            return _employees.ContainsKey(id) ? _employees[id] : null;
        }

        public void SaveHistory(Employee employee)
        {
            if (!_history.ContainsKey(employee.Id))
            {
                _history[employee.Id] = new List<Employee>();
            }
            _history[employee.Id].Add(employee);
        }

        public IEnumerable<Employee> RetrieveHistory(int id)
        {
            return _history.ContainsKey(id) ? _history[id] : new List<Employee>();
        }
    }
}