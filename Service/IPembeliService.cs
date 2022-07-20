using UASPemrograman2.ModelDB;
namespace UASPemrograman2.Service
{
    public interface IPembeliService
    {
        public Task<List<Pembeli>> GetPembeli();

        public void AddPembeli(Pembeli Pmb);
        public void DelPembeli(Pembeli Pmb);
        public void UpdPembeli(Pembeli Pmb);


    }
}
