using System;
using Stickers.Data.Context;
using Stickers.Data.Entities;
using System.Collections.Generic;

namespace Stickers.Core.Services
{
    public class BusinessClientsService
    {
        public List<BusinessClient> GetClients()
        {
            using var context = new StickersDbContext();
            var repository = new Repository<BusinessClient>(context);
            return repository.GetAll();
        }

        public BusinessClient UpdateClient(BusinessClient client)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<BusinessClient>(context);
            return repository.Update(client);
        }

        public BusinessClient AddClient(BusinessClient client)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<BusinessClient>(context);
            return repository.Add(client);
        }

        public void DeleteClient(int id)
        {
            try
            {
                using var context = new StickersDbContext();
                var repository = new Repository<BusinessClient>(context);
                var result = repository.Delete(id);
                if (result == null)
                {
                    throw new Exception("Клиент уже удален.");
                }
            }
            catch
            {
                throw new Exception("Не надо удалять клиента, у которого еще есть заказы. Ай-ай-ай.");
            }
        }
    }
}
