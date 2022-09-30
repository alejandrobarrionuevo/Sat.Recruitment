using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Entities;
using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sat.Recruitment.Services
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        public UserService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public Task<UserDTO> CreateAsync(UserDTO user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FindAsync(UserDTO user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<UserDTO>> IUserService.GetAllAsync(CancellationToken cancellationToken)
        => _repositoryManager.UserRepository.GetAllAsync(cancellationToken);

        Task<UserDTO> IUserService.GetByNameAsync(string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
