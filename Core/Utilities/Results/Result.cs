using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message) : this(success) // İki parametre gönderen birisi için 2 parametreli constructor çalışır. Aynı zamanda "this" ilede bir parametreli olanıda çalıştır demiş oldum.
        {
            Message = message; // Altta tanımlamış olduğumuz Message sadece get yani okunabilir olması rağmen constructor içerisinde set edilebilir !
        }

        public Result(bool success)
        {   
            Success = success;  // Altta tanımlamış olduğumuz Message sadece get yani okunabilir olması rağmen constructor içerisinde set edilebilir !
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
