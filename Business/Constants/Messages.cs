using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages //Static olduğundan dolayı new'lemeden kullanabiliriz. Messages. dediğimiz anda bütün özellikleri gelir.
    {
        public static string ProductAdded = "Ürün eklendi"; //Sınıf static olduğundan dolayı field'da statik olmak zorundadır.
        public static string ProductNameInValid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi.";
    }
}