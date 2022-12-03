using TestProject.Data.Entity;
using TestProject.Data.Model;

namespace TestProject.Repository.User
{
    public interface IUserRepository : IRepository<UserEntity>, IAsyncRepository<UserEntity>
    {
        Task<int> Create(UserFormModel userFormModel);
        Task<UserModel> GetUserbyId(int id);
        Task<List<UserModel>> List();
    }
}
