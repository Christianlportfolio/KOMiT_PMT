using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class EmployeeRepository : IEmployeeRepository
{
    private DatabaseContext _context;
    public EmployeeRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Employee>> GetAll()
    {
        var result = _context.Employees.Select(x => new Employee(
          x.Id,
          x.Name,
          x.JobPosition,
          x.Email,
          x.Competences.Select(c => new Competence(
                c.Id,
                c.Title,
                c.Description,
                c.Experience
            )
          ).ToList()
      ));
        return await result.ToListAsync();
    }

    public async Task CreateEmployee(Employee employee)
    {
        var result = _context.Employees.Add(employee);
        await _context.SaveChangesAsync();

    }
}


