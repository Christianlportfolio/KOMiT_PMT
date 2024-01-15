using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public interface IEmployeeService
{
    Task<ICollection<Employee>> GetAll();
    Task CreateEmployee(Employee employee);
}
