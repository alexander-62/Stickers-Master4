using System;
using System.Collections.Generic;
using Stickers.Data.Context;
using Stickers.Data.Entities;

namespace Stickers.Core.Services
{
    public class FilmService
    {
        public Film AddFilm(Film film)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Film>(context);
            return repository.Add(film);
        }

        public List<Film> GetFilms()
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Film>(context);
            return repository.GetAll();
        }

        public Film GetFilmById(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Film>(context);
            return repository.Get(id);
        }

        public Film UpdateFilm(Film film)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Film>(context);
            return repository.Update(film);
        }

        public void DeleteFilm(int id)
        {
            try
            {
                using var context = new StickersDbContext();
                var repository = new Repository<Film>(context);
                var result = repository.Delete(id);
                if (result == null)
                {
                    throw new Exception("Пленка уже удалена.");
                }
            }
            catch
            {
                throw new Exception("Не надо удалять пленку, у которой еще есть заказы или рулоны. Ай-ай-ай.");
            }
        }
    }
}
