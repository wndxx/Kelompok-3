using System.ComponentModel.DataAnnotations;

namespace Programming2_UAS.modelDB
{
    public partial class Pizza
    {
        public Pizza(){}
        public string ukuranpizzaDeskirpsi{
            get{
                if (UkuranPizza == 1)
                return "besar";
                else
                return "kecil";
            }
        }
    }
}