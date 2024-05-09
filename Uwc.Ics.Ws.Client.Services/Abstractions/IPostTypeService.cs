using Uwc.Ics.Ws.Client.Application.Models;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IPostTypeService
    {
        /// <summary>
        /// service to get All the posttypes
        /// </summary>
        /// <returns></returns>
        Task<List<PostType>> GetPostTypes();

        /// <summary>
        /// Get a PostType(s) by name
        /// </summary>
        /// <param name="PostTypeId"></param>
        /// <returns></returns>
        Task<List<PostType>> GetPostTypeByName(string name);      

        /// <summary>
        /// Get a PostType by Id.
        /// </summary>
        /// <returns></returns>
        Task<PostType> GetPostTypeById(Guid id);
    }
}
