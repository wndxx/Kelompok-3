using Programming2.ModelDB;

namespace Programming2.Services
{
    public class CakeDBService
    {
        prog2dbContext db;
        public CakeDBService(prog2dbContext _db) => db = _db;
        public List<Cake> GetCake() => db.Cakes.ToList();
        public void deleteCake(Cake m){
            var e = db.Cakes.FirstOrDefault(d=>d.Id == m.Id);
            if(e != null) {
                db.Cakes.Remove(e);
                db.SaveChanges();
            }
        }

        public void updateCake(Cake m){
            var e = db.Cakes.FirstOrDefault(d=>d.Id == m.Id);
            if(e != null) {
                e.Stok = m.Stok;
                e.Nama = m.Nama;
                e.Harga = m.Harga;
                db.Cakes.Update(e);
                db.SaveChanges();
            }
        }

        public void addCake(Cake m){
            db.Cakes.Add(m);
            db.SaveChanges();
        }
    }
}