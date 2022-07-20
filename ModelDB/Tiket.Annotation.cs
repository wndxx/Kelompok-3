using System.ComponentModel.DataAnnotations;

namespace UASPemrograman2.ModelDB
{
    public class FormTiket : Tiket
    {
        [Required(ErrorMessage = "Pembeli Harus Dipilih")]
        public int IdPembeli { get; set; }
        [Required(ErrorMessage = "Film Harus Dipilih")]
        public int IdFilm { get; set; }
        public string? NamaPembeli { get; set; }

        public string? NamaFilm { get; set; }
        public int? Harga { get; set; }
        public string? Jam { get; set; }
        public string? Tanggal { get; set; }

        public Tiket ToBase()
        {
            return new Tiket
            {
                IdTiket = this.IdTiket,
                IdPembeli = this.IdPembeli,
                IdFilm = this.IdFilm,
                Tanggal=this.Tanggal,
            };
        }




    }
}
