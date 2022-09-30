using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Entities;
using Sat.Recruitment.Domain.Repositories;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sat.Recruitment.Persistence
{
    internal class UserRepository : IUserRepository
    {
        public Task<IEnumerable<UserDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            List<UserDTO> result = new List<UserDTO>();
            var reader = ReadUsersFromFile();
            while (reader.Peek() >= 0)
            {
                var line = reader.ReadLineAsync().Result;
                var user = new UserDTO
                {
                    Name = line.Split(',')[0].ToString(),
                    Email = line.Split(',')[1].ToString(),
                    Phone = line.Split(',')[2].ToString(),
                    Address = line.Split(',')[3].ToString(),
                    UserType = line.Split(',')[4].ToString(),
                    Money = decimal.Parse(line.Split(',')[5].ToString()),
                };
                result.Add(user);
            }
            reader.Close();

            return Task.FromResult(result.AsEnumerable());
        }

        public Task<UserDTO> GetByNameAsync(string userName, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(UserDTO user)
        {
            
        }

        private StreamReader ReadUsersFromFile()
        {
            var path = Directory.GetCurrentDirectory() + "/Files/Users.txt";

            FileStream fileStream = new FileStream(path, FileMode.Open);

            StreamReader reader = new StreamReader(fileStream);
            return reader;
        }
    }
}