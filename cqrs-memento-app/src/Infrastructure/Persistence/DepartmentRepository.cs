using System.Collections.Generic;
using cqrs_memento_app.Domain.Interfaces;

namespace cqrs_memento_app.Infrastructure.Persistence
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly Dictionary<int, List<Department>> _history = new Dictionary<int, List<Department>>();
        private readonly Dictionary<int, Department> _departments = new Dictionary<int, Department>();

        public void Save(Department department)
        {
            _departments[department.Id] = department;
        }

        public Department Retrieve(int id)
        {
            return _departments.ContainsKey(id) ? _departments[id] : null;
        }

        public void SaveHistory(Department department)
        {
            if (!_history.ContainsKey(department.Id))
            {
                _history[department.Id] = new List<Department>();
            }
            _history[department.Id].Add(department);
        }

        public IEnumerable<Department> RetrieveHistory(int id)
        {
            return _history.ContainsKey(id) ? _history[id] : new List<Department>();
        }
    }
}