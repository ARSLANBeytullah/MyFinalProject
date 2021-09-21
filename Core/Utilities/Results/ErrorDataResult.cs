using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult
    {
        public class ErrorsDataResult<T> : DataResult<T>
        {  //Bütün opsiyonlarını kodladım.
            public ErrorsDataResult(T data, string message) : base(data, false, message)
            {

            }

            public ErrorsDataResult(T data) : base(data, false)
            {

            }

            public ErrorsDataResult(string message) : base(default, false, message) // t 'yi default aldım. 
            {

            }
            public ErrorsDataResult() : base(default, false)
            {

            }
        }
    }
}
