using TestProject.Data.Model;

namespace TestProject.Service.User
{
    public interface IUserService
    {
        Task<int> Create(UserFormModel userFormModel);

        Task<List<UserModel>> List();

        Task<UserModel> GetUser(int id);
    }
}
