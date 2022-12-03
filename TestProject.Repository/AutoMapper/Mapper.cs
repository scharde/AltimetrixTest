using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TestProject.Data.Entity;
using TestProject.Data.Model;

namespace HEQ.Bussiness.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public AutoMapperProfile()
        {
            CreateMap<UserFormModel, UserEntity>();
            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();

            CreateMap<AccountFormModel, AccountEntity>();
            CreateMap<AccountEntity, AccountModel>();
            CreateMap<AccountModel, AccountEntity>();

            //CreateMap<QuestionEntity, QuestionModel>().
            //  ForMember(dest => dest.questionOptionModel, source => source.MapFrom(source => source.QuestionOptionEntities.OrderBy(x => x.Code)));

        }
    }
}
