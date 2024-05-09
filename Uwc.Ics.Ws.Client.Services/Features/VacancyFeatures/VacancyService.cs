using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Uwc.Ics.Ws.Client.Application.Abstractions;
using Uwc.Ics.Ws.Client.Application.Features.UserFeatures;
using Uwc.Ics.Ws.Client.Application.Models;
using Uwc.Ics.Ws.Client.Application.Models.Dto;
using Uwc.Ics.Ws.Client.Application.Options;

namespace Uwc.Ics.Ws.Client.Application.Features.VacancyFeatures
{
    public class VacancyService : IVacancyService
    {
        private readonly ILogger<VacancyService> _logger;
        private readonly HttpClient _client;
        public VacancyService(ILogger<VacancyService> logger, HttpClient client, IOptions<WorkStudyApi> options)
        {
            _logger = logger;

            _client = client;
            _client.BaseAddress = new System.Uri(options.Value.Endpoint);
           // _client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", options.Value.ApiKey);
        }

        public Task UpdateVacancy(UpdateVacancy request)
        {
            throw new NotImplementedException();
        }
        public Task<Vacancy> CreateVacancy(CreateVacancy request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteVacancy(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vacancy>> GetAllVacancies(string name = null)
        {
            //use above format
            var response = await _client.GetAsync($"vacancy/?name={name}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var vacancies = JsonConvert.DeserializeObject<List<Vacancy>>(json);
                return vacancies;
            }

            return new List<Vacancy>();
        }

        public Task<List<Vacancy>> GetAllVacancies(int skip, int top, string name = null)
        {
            throw new NotImplementedException();
        }


        // https:baseadress/v1/vacancies/[?name][&upn][&skip][&top]
        /// <summary>
        /// Query all vacancies.
        /// </summary>
        /// <param name="name">The name to match, if not supplied all vacancy are returned.</param>
        /// <returns></returns>
        public async Task<List<Vacancy>> GetVacancies()
        {
            //use above format
            var response = await _client.GetAsync($"vacancy");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var vacancies = JsonConvert.DeserializeObject<List<Vacancy>>(json);
                return vacancies;
            }

            return new List<Vacancy>();
        }

        public async Task<Vacancy> GetVacancy(Guid id)
        {
            var response = await _client.GetAsync($"vacancy?{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var vacancy = JsonConvert.DeserializeObject<Vacancy>(json);
                if(vacancy is not null)
                return vacancy;
            }

            return null;
        }

       
    }
}
