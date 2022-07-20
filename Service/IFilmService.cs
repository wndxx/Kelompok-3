using UASPemrograman2.ModelDB;
namespace UASPemrograman2.Service
{
    public interface IFilmService
    {
        public Task<List<Film>> GetFilm();

        public void AddFilm(Film Fl);
        public void DelFilm(Film Fl);
        public void UpdFilm(Film Fl);


    }
}
