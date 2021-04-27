using System.Collections.Generic;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
  public interface IUserRepository
  {
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUserById(int Id);
  }
}