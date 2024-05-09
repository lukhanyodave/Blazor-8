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

namespace Uwc.Ics.Ws.Client.Application.Features.PostFeatures
{
    public class PostService : IPostService
    {
        private readonly ILogger<PostService> _logger;
        private readonly HttpClient _client;

        public PostService(ILogger<PostService> logger, HttpClient client, IOptions<WorkStudyApi> options)
        {
            _logger = logger;

            _client = client;
            _client.BaseAddress = new System.Uri(options.Value.Endpoint);
            //_client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", options.Value.ApiKey);
        }
        public async Task<List<Post>> GetAllPosts(int skip, int top, string name = null)
        {
            var response = await _client.GetAsync($"post");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Post>>(json);

                return results;
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">is for post</param>
        /// <returns></returns>
        public async Task<Post> GetPostById(Guid id)
        {
            var response = await _client.GetAsync($"post?Id={id}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<Post>(json);
                if(results is not null)
                return results;
            }

            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">name of post</param>
        /// <returns></returns>
        public async Task<List<Post>> GetPostByName(string name = null)
        {
            var response = await _client.GetAsync($"post?name={name}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Post>>(json);
                if (results is not null)
                    return results;
            }

            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>all post </returns>
        public async Task<List<Post>> GetPosts()
        {
            var response = await _client.GetAsync($"post");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Post>>(json);
                if (results is not null)
                    return results;
            }

            return null;
        }
    }
}
