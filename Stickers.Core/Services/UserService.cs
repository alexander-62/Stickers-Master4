using System;
using Stickers.Data.Context;
using Stickers.Data.Entities;
using System.Collections.Generic;

namespace Stickers.Core.Services
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            using var context = new StickersDbContext();
            var repository = new Repository<User>(context);
            return repository.GetAll();
        }

        public User GetUserById(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<User>(context);
            return repository.Get(id);
        }

        public User UpdateUser(User user)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<User>(context);
            return repository.Update(user);
        }

        public void DeleteUser(int id)
        {
            try
            {
                using var context = new StickersDbContext();
                var repository = new Repository<User>(context);
                var result = repository.Delete(id);
                if (result == null)
                {
                    throw new Exception("Пользователь уже удален.");
                }
            }
            catch
            {
                throw new Exception("Не надо удалять этого пользователя. Ай-ай-ай.");
            }

        }

        public User RegisterUser(User user)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<User>(context);
            return repository.Add(user);
        }
    }
}
