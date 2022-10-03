
using Sat.Recruitment.Contracts;
using Sat.Recruitment.Contracts.Mapper;
using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Sat.Recruitment.Services.Factories;
using Sat.Recruitment.Domain.Exceptions;
using System.Linq;


namespace Sat.Recruitment.Services
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly UsersFactory _usersFactory;

        public UserService(IRepositoryManager repositoryManager,  UsersFactory usersFactory)
        {
            _repositoryManager = repositoryManager;
            _usersFactory = usersFactory;
        }
        public async Task<bool> CreateAsync(UserDTO user, CancellationToken cancellationToken = default)
        {
            if (await FindAsync(user, cancellationToken))
                throw new UserDuplicatedException();

            var newUser = _usersFactory.CreateUser(user);

            newUser.AddGift();

            return await _repositoryManager.UserRepository.Insert(newUser);
        }

        public async Task<bool> FindAsync(UserDTO user, CancellationToken cancellationToken = default)
        => await _repositoryManager.UserRepository.Find(_usersFactory.CreateUser(user));

        async Task<IEnumerable<UserDTO>> IUserService.GetAllAsync(CancellationToken cancellationToken)
        {

            var users = await _repositoryManager.UserRepository.GetAllAsync(cancellationToken);
            return users.Select(user => user.ToUserDTO());
        }
    }
}
