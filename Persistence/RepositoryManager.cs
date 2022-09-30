using Sat.Recruitment.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Persistence
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IUserRepository> _lazyUserRepository;
        public RepositoryManager()
        {
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository());
        }
        public IUserRepository UserRepository => _lazyUserRepository.Value;
    }
}
