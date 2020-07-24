using JobMercadoLivre.Controllers;
using JobMercadoLivre.Modelss;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace JobMercadoLivre.Request.Pedidos
{
    public class GET
    {
        public static string Ordem()
        {
            var client = new RestClient("https://api.mercadolibre.com/orders/2347791918?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Modelss.Ordem.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Modelss.Ordem.RootObject>(response.Content).ToString();
        }

        public static string NotasDeOrdem()
        {

            var client = new RestClient("https://api.mercadolibre.com/orders/2347791918/notes?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<List<Modelss.NotasDeOrdem.RootObject>>(response.Content);

            return retorno[0].order_id.ToString();
        }

        public static string PedidoMLB()
        {
            var client = new RestClient("https://api.mercadolibre.com/items/MLB1459710850?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Host", "api.mercadolibre.com");
            request.AddHeader("Postman-Token", "8ae652fe-29fa-4199-b960-6962a7be1070,e5b513a8-5975-4cc9-967e-d943583fc470");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<PedidoMLB.RootObject>(response.Content);

            return retorno.ToString();
        }
        public static string Buscar_Os_Pedidos_De_Um_Vendedor()
        {

            var client = new RestClient("https://api.mercadolibre.com/orders/search?seller=533461433&access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Host", "api.mercadolibre.com");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Modelss.Buscar_Os_Pedidos_De_Um_Vendedor.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Modelss.Buscar_Os_Pedidos_De_Um_Vendedor.RootObject>(response.Content).ToString();
        }
        public static string ConsultarDadosPessoais()
        {
            var client = new RestClient("https://api.mercadolibre.com/users/me?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Host", "api.mercadolibre.com");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Modelss.ConsultarDadosPessoais.RootObject>(response.Content);

            return retorno.ToString();
        }
        public static string ChecarSaldoEmConta()
        {
            var client = new RestClient("https://api.mercadolibre.com/users/533461433/mercadopago_account/balance?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Host", "api.mercadolibre.com");
            request.AddHeader("Postman-Token", "a0427864-7867-4b73-ab5c-fad705b1ac13,2b11d4b1-0640-4d6f-abe1-22a2919f1d88");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Modelss.ChecarSaldoEmConta.RootObject>(response.Content);

            return retorno.ToString();
        }


        public static string PagamentosAceitosPeloVendedor()
        {
            var client = new RestClient("https://api.mercadolibre.com/users/533461433/accepted_payment_methods?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Host", "api.mercadolibre.com");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<List<Modelss.PagamentosAceitosPeloVendedor.RootObject>>(response.Content);

            return retorno.ToString();
        }

    }
}
