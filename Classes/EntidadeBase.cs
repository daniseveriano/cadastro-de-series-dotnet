using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_de_series_dotnet
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
    }
}