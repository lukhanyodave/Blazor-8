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
using Uwc.Ics.Ws.Client.Application.Models;
using Uwc.Ics.Ws.Client.Application.Options;

namespace Uwc.Ics.Ws.Client.Application.Features.DepartmentFeatures
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ILogger<DepartmentService> _logger;
        private readonly HttpClient _client;

        public DepartmentService(ILogger<DepartmentService> logger, HttpClient client, IOptions<WorkStudyApi> options)
        {
            _logger = logger;

            _client = client;
            _client.BaseAddress = new System.Uri(options.Value.Endpoint);            
        }
       
        public async Task<Department> GetDepartmentById(Guid id)
        {
            var response = await _client.GetAsync($"departments?id={id}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<Department>(json);
                if (results is not null)
                    return results;
            }
            return null;
        }

        public async Task<List<Department>> GetDepartmentByName(string name)
        {
            var response = await _client.GetAsync($"departments?name={name}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Department>>(json);
                if(results is not null)
                return results.ToList();
            }
            return null;
        }

        public async  Task<List<Department>> GetDepartments()
        {
            var response = await _client.GetAsync($"departments");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Department>>(json);
                if (results is not null)
                    return results.ToList();
            }
            return null;
        }
    }
}
