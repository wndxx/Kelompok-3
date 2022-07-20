using System;
using System.Collections.Generic;

namespace Programming2.ModelDB
{
    public partial class Cake
    {
        public int Id { get; set; }
        public string Nama { get; set; } = null!;
        public int Stok { get; set; }
        public string Harga { get; set; } = null!;
    }
}
