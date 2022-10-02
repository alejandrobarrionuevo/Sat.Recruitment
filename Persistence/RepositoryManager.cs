
using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Persistence.Files;
using Sat.Recruitment.Services.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Persistence
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IUserRepository> _lazyUserRepository;

        public RepositoryManager(UsersFactory usersFactory)
        {
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(usersFactory));            
        }
        public IUserRepository UserRepository => _lazyUserRepository.Value;
    }
}
