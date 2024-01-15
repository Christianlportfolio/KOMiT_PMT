using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface IEmployeeRepository
{
    Task<ICollection<Employee>> GetAll();
    Task CreateEmployee(Employee employee);
}
