

using Microsoft.Extensions.DependencyInjection;
using TestProject.Repository.Account;
using TestProject.Repository.User;
using TestProject.Service.Account;
using TestProject.Service.User;

namespace TestProject.WebAPI.Configuration
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection builder)
        {
            //Service
            builder.AddScoped<IUserService, UserService>();
            builder.AddScoped<IAccountService, AccountService>();


            //Repository
            builder.AddScoped<IUserRepository, UserRepository>();
            builder.AddScoped<IAccountRepository, AccountRepository>();

        }
    }
}
