using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Services.Abstractions;
using Sat.Recruitment.Services.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _lazyUserService;
        public ServiceManager(IRepositoryManager repositoryManager, UsersFactory usersFactory)
         => _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager, usersFactory));

        public IUserService UserService => _lazyUserService.Value;
    }
}
