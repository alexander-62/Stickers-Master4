using Stickers.Data.Context;
using Stickers.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Stickers.Core.Services
{
    public class RollService
    {
        public Roll AddRoll(Roll roll)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Roll>(context);
            return repository.Add(roll);
        }

        public List<Roll> GetRolls()
        {
            using var context = new StickersDbContext();
            return context.Rolls
                .Include(x => x.Film)
                .ToList();
        }

        public Roll GetRollById(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Roll>(context);
            return repository.Get(id);
        }

        public Roll UpdateRoll(Roll roll)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Roll>(context);
            return repository.Update(roll);
        }

        public void DeleteRoll(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Roll>(context);
            var result = repository.Delete(id);
            if (result == null)
            {
                throw new Exception("Рулон уже удален.");
            }
        }
    }
}
