using System;
using System.Collections.Generic;

namespace UASPemrograman2.ModelDB
{
    public partial class Film
    {
       public string JenisRating(){
         if(Rating==7){
            return "Anak-Anak";
         }else if(Rating==13){
            return "Remaja";
         }else if(Rating==17){
            return "Dewasa";
         }else{
            return "Semua Umur";
         }
       }
    }
}
