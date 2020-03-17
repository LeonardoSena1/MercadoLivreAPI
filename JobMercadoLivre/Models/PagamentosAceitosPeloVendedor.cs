using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMercadoLivre.Modelss
{
    public class PagamentosAceitosPeloVendedor
    {
        public class RootObject
        {
            public string id { get; set; }
            public string name { get; set; }
            public string payment_type_id { get; set; }
            public string thumbnail { get; set; }
            public string secure_thumbnail { get; set; }
        }
    }
}
