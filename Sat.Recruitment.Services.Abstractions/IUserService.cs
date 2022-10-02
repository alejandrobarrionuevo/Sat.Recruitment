
using Sat.Recruitment.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sat.Recruitment.Services.Abstractions
{
    public interface IUserService
    {
        /// <summary>
        /// Get all the users
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>UserDTOs Enumerable</returns>
        Task<IEnumerable<UserDTO>> GetAllAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Find user
        /// </summary>
        /// <param name="user">User to find</param>
        /// <param name="cancellationToken"></param>
        /// <returns>True if user found; otherwise False</returns>
        Task<bool> FindAsync(UserDTO user, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user">User to create</param>
        /// <param name="cancellationToken"></param>
        /// <returns>True if user create; otherwise False</returns>
        Task<bool> CreateAsync(UserDTO user, CancellationToken cancellationToken = default);
    }
}
