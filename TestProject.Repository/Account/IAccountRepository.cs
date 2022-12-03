using TestProject.Data.Entity;
using TestProject.Data.Model;

namespace TestProject.Repository.Account
{
    public interface IAccountRepository : IRepository<AccountEntity>, IAsyncRepository<AccountEntity>
    {
        Task<List<AccountModel>> List(int userId);
        Task<AccountModel> Create(AccountFormModel accountFormModel);
    }
}
