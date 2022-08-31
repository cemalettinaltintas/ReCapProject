using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //<T> ->Hangi tipi döndüreceğini bana söyle.
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
