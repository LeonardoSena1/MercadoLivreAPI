using System;

namespace JobMercadoLivre.Modelss
{
    public class ErrorViewModels
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
