namespace cqrs_memento_app.Domain.Interfaces
{
    public interface IDepartmentRepository
    {
        void Save(Department department);
        Department Retrieve(int id);
        void SaveHistory(Department department);
        IEnumerable<Department> RetrieveHistory(int id);
    }

}