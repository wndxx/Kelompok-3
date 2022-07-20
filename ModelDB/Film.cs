using System;
using System.Collections.Generic;

namespace UASPemrograman2.ModelDB
{
    public partial class Film
    {
        public int IdFilm { get; set; }
        public string? NamaFilm { get; set; }
        public int? Harga { get; set; }
        public string? Jam { get; set; }
        public int Rating { get; set; }
    }
}
