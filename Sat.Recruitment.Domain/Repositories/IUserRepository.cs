
using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sat.Recruitment.Domain.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Get all saved users
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Users Enumerable</returns>
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user">User to add</param>
        /// <returns>True if user is add; otherwise False</returns>
        Task<bool> Insert(User user);
        /// <summary>
        /// Find saved user
        /// </summary>
        /// <param name="user">User to find</param>
        /// <returns>True if saved user is found; otherwise False</returns>
        Task<bool> Find(User user);
    }
}
