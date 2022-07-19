using System;
using System.Collections.Generic;

namespace Programming2_UAS.modelDB
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string? NamaPizza { get; set; }
        public int? UkuranPizza { get; set; }
        public string? JenisSaus { get; set; }
        public string? Crust { get; set; }
    }
}
