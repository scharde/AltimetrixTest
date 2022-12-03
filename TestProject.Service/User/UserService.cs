using AutoMapper;
using TestProject.Data.Model;
using TestProject.Repository.User;

namespace TestProject.Service.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Create(UserFormModel userFormModel)
        {
            int result = await _userRepository.Create(userFormModel);
            return result;
        }

        public async Task<UserModel> GetUser(int id)
        {
            return await _userRepository.GetUserbyId(id);
        }

        public async Task<List<UserModel>> List()
        {
            return await _userRepository.List();
        }
    }
}
