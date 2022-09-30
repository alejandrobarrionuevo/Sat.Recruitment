using System;
using System.Dynamic;

using Microsoft.AspNetCore.Mvc;

using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Contracts;
using Sat.Recruitment.Persistence;
using Sat.Recruitment.Services;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var userController = new UsersController(new ServiceManager(new RepositoryManager()));

            /*var newUser = new UserDTO { 
                Address = "Av. Juan G",
                Name = "Mike",
                Email = "mike@gmail.com",
                Phone = "+349 1122354215",
                UserType = "Normal",
                Money = "124
            }*/

            var result = userController.CreateUser(
                                
                "Mike", "mike@gmail.com", "Av. Juan G", "+349 1122354215", "Normal", "124").Result;


            Assert.Equal(true, result.IsSuccess);
            Assert.Equal("User Created", result.Errors);
        }

        [Fact]
        public void Test2()
        {
            var userController = new UsersController(new ServiceManager(new RepositoryManager()));

            var result = userController.CreateUser("Agustina", "Agustina@gmail.com", "Av. Juan G", "+349 1122354215", "Normal", "124").Result;


            Assert.Equal(false, result.IsSuccess);
            Assert.Equal("The user is duplicated", result.Errors);
        }
    }
}
