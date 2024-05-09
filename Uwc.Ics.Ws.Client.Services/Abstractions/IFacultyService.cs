using Uwc.Ics.Ws.Client.Application.Models;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IFacultyService
    {
        /// <summary>
        /// Get a Faculty(s) by name
        /// </summary>
        /// <param name="FacultyId"></param>
        /// <returns></returns>
        Task<List<Faculty>> GetFacultyByName(string name);
        /// <summary>
        /// Get a Faculty b.
        /// </summary>
        /// <returns></returns>
        Task<List<Faculty>> GetFaculties();

        /// <summary>
        /// Get a Faculty by Id.
        /// </summary>
        /// <returns></returns>
        Task<Faculty> GetFacultyById(Guid id);
    }
}
