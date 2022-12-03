using TestProject.Data.Model;
using TestProject.Repository.Account;

namespace TestProject.Service.Account
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountModel> Create(AccountFormModel accountFormModel)
        {
           return await _accountRepository.Create(accountFormModel);
        }

        public async Task<List<AccountModel>> List(int userId)
        {
           return await _accountRepository.List(userId);
        }
    }
}
