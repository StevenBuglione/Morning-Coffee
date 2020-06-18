using System;
using System.Threading.Tasks;
using Morning_Coffee_Backend.Models;
using Morning_Coffee_Backend.Utilities;

namespace Morning_Coffee_Backend.Data.Interfaces
{
    public interface ICoffeeRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<PagedList<User>> GetUsers(UserParams userParams);

        Task<User> GetUser(int id, bool isCurrentUser);

        Task<Photo> GetPhoto(int id);

        Task<Photo> GetMainPhotoForUser(int userId);
    }
}
