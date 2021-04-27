using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Core.Services
{
  public class PostService : IPostService
  {
    private readonly IRepository<Post> _postRepository;
    private readonly IRepository<User> _userRepository;

    public PostService(IRepository<Post> postRepository, IRepository<User> userRepository)
    {
      _postRepository = postRepository;
      _userRepository = userRepository;
    }

    public async Task<Post> GetPostById(int id)
    {
      var response = await _postRepository.GetById(id);
      return response;
    }

    public async Task<IEnumerable<Post>> GetPosts()
    {
      var response = await _postRepository.GetAll();
      return response;
    }

    public async Task InserPost(Post post)
    {
      var user = await _userRepository.GetById(post.UserId);
      if (user == null)
      {
        throw new Exception("User doesn't exist");
      }
      if (post.Description.Contains("sexo"))
      {
        throw new Exception("Content now allowed");
      }
      await _postRepository.Add(post);
    }

    public async Task<bool> UpdatePost(Post post)
    {
      await _postRepository.Update(post);
      return true;
    }

    public async Task<bool> DeletePost(int Id)
    {
      await _postRepository.Delete(Id);
      return true;
    }

  }
}
