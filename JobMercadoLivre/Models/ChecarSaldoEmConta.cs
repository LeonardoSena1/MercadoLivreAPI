using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMercadoLivre.Modelss
{
    public class ChecarSaldoEmConta
    {
        public class UnavailableBalanceByReason
        {
            public string reason { get; set; }
            public int amount { get; set; }
        }

        public class AvailableBalanceByTransactionType
        {
            public string transaction_type { get; set; }
            public int amount { get; set; }
        }

        public class RootObject
        {
            public DateTime last_modified { get; set; }
            public int user_id { get; set; }
            public int total_amount { get; set; }
            public int pending_to_review { get; set; }
            public int available_balance { get; set; }
            public int unavailable_balance { get; set; }
            public string currency_id { get; set; }
            public List<object> tags { get; set; }
            public object block_reason { get; set; }
            public List<UnavailableBalanceByReason> unavailable_balance_by_reason { get; set; }
            public List<AvailableBalanceByTransactionType> available_balance_by_transaction_type { get; set; }
        }

    }
}
