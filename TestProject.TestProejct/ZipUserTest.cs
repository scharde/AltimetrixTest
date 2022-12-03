using Microsoft.AspNetCore.Mvc;
using Moq;
using TestProject.Data.Model;
using TestProject.Repository.User;
using TestProject.Service.User;
using TestProject.WebAPI.Controllers;

namespace TestProject.TestProejct
{
    public class ZipUserTest
    {
        private readonly UserController _userController;
        private readonly Mock<IUserService> _userService;
        private readonly Mock<IUserRepository> _userRepository;

        public ZipUserTest()
        {
            _userService = new Mock<IUserService>();
            _userRepository = new Mock<IUserRepository>();
            _userController = new UserController(_userService.Object);
        }

        [Fact]
        public async void TestGetUser()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(getUserModel());

            _userService.Setup(x => x.List()).ReturnsAsync(users);
            var result = await _userController.Get();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void TestGetUser_Single()
        {
            _userService.Setup(x => x.GetUser((int)1)).ReturnsAsync(getUserModel());
            var result = await _userController.Get((int)1);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void TestCreateUser()
        {
            _userService.Setup(x => x.Create(It.IsAny<UserFormModel>())).ReturnsAsync(It.IsAny<int>());
            var result = await _userController.Post(It.IsAny<UserFormModel>());
            Assert.IsType<OkObjectResult>(result);
        }

        private UserModel getUserModel()
        {
            UserModel user = new UserModel() { Email = "abc@gmail.com", Name = "abc", MonthlyExpense = 2000, MonthlySalary = 5000, IsValidForAccount = true };
            return user;
        }
    }
}