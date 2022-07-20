using Microsoft.EntityFrameworkCore;
using UASPemrograman2.ModelDB;
namespace UASPemrograman2.Service
{
    public class PembeliDBService : IPembeliService
    {
        projectuasContext db;

        public PembeliDBService(projectuasContext _db) => db = _db;

        public Task<List<Pembeli>> GetPembeli()
        {
            return db.Pembelis.ToListAsync();
        }

        void IPembeliService.AddPembeli(Pembeli Pmb)
        {
            db.Pembelis.Add(Pmb);
            db.SaveChanges();
        }

        void IPembeliService.DelPembeli(Pembeli Pmb)
        {
            var x = db.Pembelis.FirstOrDefault(d => d.IdPembeli == Pmb.IdPembeli);
            if (x != default)
            {
                db.Pembelis.Remove(x);
                db.SaveChanges();
            }
        }

        void IPembeliService.UpdPembeli(Pembeli Pmb)
        {
            var x = db.Pembelis.FirstOrDefault(d => d.IdPembeli == Pmb.IdPembeli);
            if (x != default)
            {
                x.NamaPembeli = Pmb.NamaPembeli;
                x.Umur=Pmb.Umur;
                db.Update(x);
                db.SaveChanges();
            }
        }

    }
}
