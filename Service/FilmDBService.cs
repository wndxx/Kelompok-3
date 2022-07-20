using Microsoft.EntityFrameworkCore;
using UASPemrograman2.ModelDB;
namespace UASPemrograman2.Service
{
    public class FilmDBService : IFilmService
    {
        projectuasContext db;

        public FilmDBService(projectuasContext _db) => db = _db;

        public Task<List<Film>> GetFilm()
        {
            return db.Films.ToListAsync();
        }

        void IFilmService.AddFilm(Film Fl)
        {
            db.Films.Add(Fl);
            db.SaveChanges();
        }

        void IFilmService.DelFilm(Film Fl)
        {
            var x = db.Films.FirstOrDefault(d => d.IdFilm == Fl.IdFilm);
            if (x != default)
            {
                db.Films.Remove(x);
                db.SaveChanges();
            }
        }

        void IFilmService.UpdFilm(Film Fl)
        {
            var x = db.Films.FirstOrDefault(d => d.IdFilm == Fl.IdFilm);
            if (x != default)
            {
                x.NamaFilm = Fl.NamaFilm;
                x.Harga = Fl.Harga;
                x.Jam = Fl.Jam;
                x.Rating=Fl.Rating;
                db.Update(x);
                db.SaveChanges();
            }
        }

    }
}
