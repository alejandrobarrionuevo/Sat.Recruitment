using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Entities;
using Sat.Recruitment.Domain.Repositories;
using Sat.Recruitment.Persistence.Files;
using Sat.Recruitment.Services.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Sat.Recruitment.Persistence
{
    internal class UserRepository : IUserRepository
    {
        const string fileName = "Users.txt";

        private readonly UsersFactory _usersFactory; 

        public UserRepository(UsersFactory usersFactory) { 
            _usersFactory = usersFactory;           
        }

        public async Task<bool> Find(User user)
        {
            var users = await GetAllAsync();
            return users.Contains(user);
        }        

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            List<User> result = new List<User>();
            var reader = FileManager.ReadFromFile(fileName);
            while (reader.Peek() >= 0)
            {
                var line = await reader.ReadLineAsync();
                var splitLine = line.Split(',');
                var user = new UserDTO()
                {
                    Name = splitLine[0],
                    Email = splitLine[1],
                    Phone = splitLine[2],
                    Address = splitLine[3],
                    UserType = splitLine[4],
                    Money = splitLine[5]
                };

                result.Add(_usersFactory.CreateUser(user));
            }

            reader.Close();

            return result.AsEnumerable();
        }

        public async Task<bool> Insert(User user)
        {
            string newLine = $"{user.Name},{user.Email},{user.Phone},{user.Address},{user.UserType},{user.Money}";
            await FileManager.AddLine(fileName, newLine);
            return true;
        }

        
    }
}