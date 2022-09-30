using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _lazyUserService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager));
        }
        public IUserService UserService => _lazyUserService.Value;        
    }
}
