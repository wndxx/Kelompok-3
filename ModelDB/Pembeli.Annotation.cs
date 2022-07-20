using System.ComponentModel.DataAnnotations;

namespace UASPemrograman2.ModelDB
{
    public class PembeliForm : Pembeli
    {
        [Required]
        [StringLength(200, ErrorMessage = "Nama Pembeli 3 Huruf", MinimumLength = 3)]
        public string? NamaPembeli { get; set; }

        public int Umur{get;set;}
        public Pembeli ToBase()
        {
            return new Pembeli
            {
                IdPembeli = this.IdPembeli,
                NamaPembeli = this.NamaPembeli,
                Umur = this.Umur
            };
        }
    }
}
