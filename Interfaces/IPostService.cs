using System.Collections.Generic;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
  public interface IPostService
  {
    Task<IEnumerable<Post>> GetPosts();
    Task<Post> GetPostById(int Id);
    Task InserPost(Post post);
    Task<bool> UpdatePost(Post post);
    Task<bool> DeletePost(int Id);
  }
}