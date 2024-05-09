using System.Data;
using Uwc.Ics.Ws.Client.Application.Models;
namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IDepartmentService
    {
        /// <summary>
        /// Get a department(s) by name
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        Task<List<Department>> GetDepartmentByName(string name);
        /// <summary>
        /// Get a department b.
        /// </summary>
        /// <returns></returns>
        Task<List<Department>> GetDepartments();

        /// <summary>
        /// Get a department by Id.
        /// </summary>
        /// <returns></returns>
       Task<Department> GetDepartmentById(Guid id);
    }
}
