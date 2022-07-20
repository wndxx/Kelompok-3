using System.ComponentModel.DataAnnotations;

namespace UASPemrograman2.ModelDB
{
    public class FilmForm : Film
    {
        [Required]
        [StringLength(200, ErrorMessage = "Nama Film Minimal 3 Huruf", MinimumLength = 3)]
        public string? NamaFilm { get; set; }
        public int? Harga { get; set; }
        public string? Jam { get; set; }
        public int Rating {get;set;}

        public Film ToBase()
        {
            return new Film
            {
                IdFilm = this.IdFilm,
                NamaFilm = this.NamaFilm,
                Harga = this.Harga,
                Jam = this.Jam,
                Rating=this.Rating
            };
        }
    }
}
