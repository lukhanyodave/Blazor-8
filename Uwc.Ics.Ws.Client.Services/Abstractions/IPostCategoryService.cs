using Uwc.Ics.Ws.Client.Application.Models;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IPostCategoryService
    {
        Task<List<PostCategory>> GetPostCategories();
        Task<PostCategory> GetPostCategory(Guid id);
        Task CreatePostCategory(PostCategory postCategory);
        Task UpdatePostCategory(Guid id, PostCategory postCategory);
        Task DeletePostCategory(Guid id);
    }
}
