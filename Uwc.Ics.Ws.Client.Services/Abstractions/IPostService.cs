using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.Client.Application.Models;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IPostService
    {
        /// <summary>
        /// Query all posts.
        /// </summary>
        /// <param name="skip">The number of users to skip.</param>
        /// <param name="top">The number of records to return.</param>
        /// <param name="name">The name to match, if not supplied all users are returned.</param>
        /// <returns></returns>
        Task<List<Post>> GetAllPosts(int skip, int top, string name = null);
        /// <summary>
        /// Get a Post(s) by name
        /// </summary>
        /// <param name="PostId"></param>
        /// <returns></returns>
        Task<List<Post>> GetPostByName(string name = null);
        /// <summary>
        /// Get a Post b.
        /// </summary>
        /// <returns></returns>
        Task<List<Post>> GetPosts();

        /// <summary>
        /// Get a Post by Id.
        /// </summary>
        /// <returns></returns>
        Task<Post> GetPostById(Guid id);
       
    }
}
