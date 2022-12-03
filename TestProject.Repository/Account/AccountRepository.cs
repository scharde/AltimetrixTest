using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestProject.Data.Entity;
using TestProject.Data.Model;
using TestProject.Repository.User;

namespace TestProject.Repository.Account
{
    public class AccountRepository : Repository<AccountEntity>, IAccountRepository
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public AccountRepository(ZipContext dbContext, IMapper mapper, IUserRepository userRepository) : base(dbContext)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<AccountModel> Create(AccountFormModel accountFormModel)
        {
            UserModel userModel = await _userRepository.GetUserbyId(accountFormModel.UserId);
            if (userModel.IsValidForAccount)
            {
                AccountEntity accountEntity = _mapper.Map<AccountFormModel, AccountEntity>(accountFormModel);
                AccountEntity result = await AddAsync(accountEntity);
                return _mapper.Map<AccountEntity, AccountModel>(result);
            }
            return null;
        }

        public async Task<List<AccountModel>> List(int userId)
        {
            List<AccountEntity> accountEntities = await _dbContext.Accounts.Where(x => x.UserId == userId).ToListAsync();
            return _mapper.Map<List<AccountEntity>, List<AccountModel>>(accountEntities);
        }
    }
}
