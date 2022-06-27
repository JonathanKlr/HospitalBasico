using System.Threading.Tasks;
using HospitalBasico.Models.TokenAuth;
using HospitalBasico.Web.Controllers;
using Shouldly;
using Xunit;

namespace HospitalBasico.Web.Tests.Controllers
{
    public class HomeController_Tests: HospitalBasicoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}