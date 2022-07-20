using Microsoft.EntityFrameworkCore;
using UASPemrograman2.ModelDB;

namespace UASPemrograman2.Service
{
    public class TiketService
    {
        projectuasContext db;

        public TiketService(projectuasContext _db) => db = _db;

        public async Task<List<FormTiket>> GetTikets()
        {
            var r = (from t in db.Tikets
                     join p in db.Pembelis on t.IdPembeli equals p.IdPembeli
                     join f in db.Films on t.IdFilm equals f.IdFilm
                     select new FormTiket
                     {
                         IdTiket = t.IdTiket,
                         IdFilm = t.IdFilm,
                         NamaPembeli = p.NamaPembeli,
                         NamaFilm = f.NamaFilm,
                         Harga = f.Harga,
                         Jam = f.Jam,
                         Tanggal=t.Tanggal
                     }
            ).ToListAsync();
            return await r;
        }

        public void AddTiket(Tiket t)
        {
            db.Tikets.Add(t);
            db.SaveChanges();
        }

        public void DelTiket(Tiket t)
        {
            var x = db.Tikets.FirstOrDefault(d => d.IdTiket == t.IdTiket);
            if (x != default)
            {
                db.Tikets.Remove(x);
                db.SaveChanges();
            }
        }
    }
}
