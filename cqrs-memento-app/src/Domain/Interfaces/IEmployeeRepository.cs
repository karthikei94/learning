namespace cqrs_memento_app.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        void Save(Employee employee);
        Employee Retrieve(int id);
        void SaveHistory(Employee employee);
        IEnumerable<Employee> RetrieveHistory(int id);
    }
}
