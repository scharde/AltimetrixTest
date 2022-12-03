using System.Runtime.InteropServices;
using TestProject.Data.Model;

namespace TestProject.Service.Account
{
    public interface IAccountService
    {

        Task<List<AccountModel>> List(int userId);

        Task<AccountModel> Create(AccountFormModel accountFormModel);

    }
}
