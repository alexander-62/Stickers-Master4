using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Stickers.Data.Context;
using Stickers.Data.Entities;
using System;
using System.Collections.Generic;

namespace Stickers.Core.Services
{
    public class CostsService
    {
        public List<Cost> GetCosts()
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Cost>(context);
            return repository.GetAll();
        }

        public Cost GetCostById(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Cost>(context);
            return repository.Get(id);
        }

        public Cost UpdateCost(Cost cost)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Cost>(context);
            return repository.Update(cost);
        }

        public Cost AddCost(Cost cost)
        {
            Cost addedCost;
            try
            {
                using var context = new StickersDbContext();
                var repository = new Repository<Cost>(context);
                addedCost = repository.Add(cost);
            }
            catch (DbUpdateException ex)
            {
                if(ex.InnerException is SqlException sqlException && sqlException.Number == 2601)
                {
                    throw new Exception("Такой тип затрат уже существует.");
                }

                throw new Exception("He удалось выполнить операцию.");
            }
            return addedCost;
        }

        public void DeleteCost(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Cost>(context);
            var result = repository.Delete(id);
            if (result == null)
            {
                throw new Exception("Цена уже удалена.");
            }
        }
    }
}
