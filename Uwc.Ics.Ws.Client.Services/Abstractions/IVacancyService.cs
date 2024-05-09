using Uwc.Ics.Ws.Client.Application.Models;
using Uwc.Ics.Ws.Client.Application.Models.Dto;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    /// <summary>
    /// A service for vacancies.
    /// </summary>
    public interface IVacancyService
    {
            /// <summary>
            /// Query all vacancies.
            /// </summary>
            /// <param name="name">The name to match, if not supplied all vacancies are returned.</param>
            /// <returns></returns>
            Task<List<Vacancy>> GetAllVacancies(string name = null);

            /// <summary>
            /// Query all Vacancys.
            /// </summary>
            /// <param name="skip">The number of Vacancys to skip.</param>
            /// <param name="top">The number of records to return.</param>
            /// <param name="name">The name to match, if not supplied all Vacancys are returned.</param>
            /// <returns></returns>
            Task<List<Vacancy>> GetAllVacancies(int skip, int top, string name = null);

            /// <summary>
            /// Get a Vacancy by id.
            /// </summary>
            /// <param name="id">The Vacancy id.</param>
            /// <returns></returns>
            Task<Vacancy> GetVacancy(Guid id);

            /// <summary>
            /// A service create Vacancy account 
            /// </summary>
            Task<Vacancy> CreateVacancy(CreateVacancy request);

            /// <summary>
            /// A service editing Vacancy account 
            /// </summary>
            Task UpdateVacancy(UpdateVacancy request);

            /// <summary>
            /// A search directory Vacancys
            /// </summary>
          //  Task<List<ADVacancy>> SearchDirectoryVacancys(string displayName);

            /// <summary>
            /// Delete a Vacancy from the application.
            /// </summary>
            /// <param name="id">The Vacancy id.</param>
            /// <returns></returns>
            Task DeleteVacancy(Guid id);
        }
}
