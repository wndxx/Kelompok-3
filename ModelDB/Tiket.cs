using System;
using System.Collections.Generic;

namespace UASPemrograman2.ModelDB
{
    public partial class Tiket
    {
        public int IdTiket { get; set; }
        public int IdPembeli { get; set; }
        public int IdFilm { get; set; }
        public string Tanggal { get; set; } = null!;
    }
}
