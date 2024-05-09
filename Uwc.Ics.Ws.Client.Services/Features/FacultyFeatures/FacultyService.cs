using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.Client.Application.Abstractions;
using Uwc.Ics.Ws.Client.Application.Models;
using Uwc.Ics.Ws.Client.Application.Options;

namespace Uwc.Ics.Ws.Client.Application.Features.FacultyFeatures
{
    public class FacultyService : IFacultyService
    {
        private readonly ILogger<FacultyService> _logger;
        private readonly HttpClient _client;

        public FacultyService(ILogger<FacultyService> logger, HttpClient client, IOptions<WorkStudyApi> options)
        {
            _logger = logger;

            _client = client;
            _client.BaseAddress = new System.Uri(options.Value.Endpoint);
        }

        public async Task<Faculty> GetFacultyById(Guid id)
        {
            var response = await _client.GetAsync($"Facultys?id={id}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<Faculty>(json);
                if (results is not null)
                    return results;
            }
            return null;
        }

        public async Task<List<Faculty>> GetFacultyByName(string name)
        {
            var response = await _client.GetAsync($"Facultys?name={name}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Faculty>>(json);
                if (results is not null)
                    return results.ToList();
            }
            return null;
        }

        public async Task<List<Faculty>> GetFaculties()
        {
            var response = await _client.GetAsync($"Facultys");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Faculty>>(json);
                if (results is not null)
                    return results.ToList();
            }
            return null;
        }

      
    }
}
