using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        

    public class OperationResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public class OperationResult<T>:OperationResult
    {
        public T Data { get; set; }
    }
}
