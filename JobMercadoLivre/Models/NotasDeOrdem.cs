using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMercadoLivre.Modelss
{
    public class NotasDeOrdem
    {
        public class RootObject
        {
            public string order_id { get; set; }
            public List<object> results { get; set; }

        }
    }
}
