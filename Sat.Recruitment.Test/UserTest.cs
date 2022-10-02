using System;
using System.Dynamic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Exceptions;
using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Persistence;
using Sat.Recruitment.Services;
using Sat.Recruitment.Services.Abstractions;
using Sat.Recruitment.Services.Factories;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UserTest
    {
        private readonly IServiceManager serviceManager;
        private readonly IRepositoryManager repositoryManager;
        private readonly UsersFactory usersFactory;

        public UserTest()
        {
            usersFactory = new UsersCreator();
            repositoryManager = new RepositoryManager(usersFactory);
            serviceManager = new ServiceManager(repositoryManager, usersFactory);            
        }
        [Fact]        
        public void CreateNewUserTest()
        {
            var userController = new UsersController(serviceManager);

            var newUser = new UserDTO
            {
                Address = "Av. Juan G",
                Name = "Mike",
                Email = "mike@gmail.com",
                Phone = "+349 1122354215",
                UserType = "Normal",
                Money = "124"
            };

            var result = userController.CreateUser(newUser).Result;


            Assert.IsType<OkResult>(result);            
        }

        [Fact]
        public void CreateDuplicatedUserTest()
        {
            var userController = new UsersController(serviceManager);

            var newUser = new UserDTO
            {
                Address = "Garay y Otra Calle",
                Name = "Agustina",
                Email = "Agustina@gmail.com",
                Phone = "+534645213542",
                UserType = "SuperUser",
                Money = "112234"
            };

            Assert.ThrowsAsync<UserDuplicatedException>(() => userController.CreateUser(newUser));
        }
    }
}
