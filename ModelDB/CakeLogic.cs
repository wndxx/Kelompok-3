using System.ComponentModel.DataAnnotations;

namespace Programming2.ModelDB
{
    
    public partial class Cake
    {
        public Cake() {}
        public string StokDeskripsi{ 
            get {
                if(Stok == 1)
                return "Stok Ada";
            else    
                return "Stok Kosong";
            }
        }
    }
}