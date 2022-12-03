using AutoMapper;
using Microsoft.Extensions.Logging;
using TestProject.Data.Entity;
using TestProject.Data.Model;

namespace TestProject.Repository.User
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        private readonly IMapper? _mapper;
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(ZipContext dbContext, IMapper mapper, ILogger<UserRepository> logger) : base(dbContext)
        {
            _mapper = mapper;
            _logger = logger;
            _logger.LogInformation("From repository class");
        }

        public async Task<int> Create(UserFormModel userFormModel)
        {
            try
            {
                UserEntity userEntity = _mapper.Map<UserFormModel, UserEntity>(userFormModel);
                userEntity.IsValidForAccount =  (userEntity.MonthlySalary - userEntity.MonthlyExpense) > 1000;
                UserEntity result = await AddAsync(userEntity);
                _logger.LogError("Its a error");
                return result.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserModel> GetUserbyId(int id)
        {
            UserEntity userEntity = await GetByIdAsync(id);
            return _mapper.Map<UserEntity, UserModel>(userEntity);
        }

        public async Task<List<UserModel>> List()
        {
            List<UserEntity> userEntities = await GetAllAsync();
            return _mapper.Map<List<UserEntity>, List<UserModel>>(userEntities);
        }
    }
}
