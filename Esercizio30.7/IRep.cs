using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30._7.Rep
{
    public interface  IRep<T>
    {
        public List<T> Fetch();
     
    }
}
