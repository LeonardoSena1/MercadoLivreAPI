using JobMercadoLivre.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos.Garantia
{
    public class Sem_Garantia
    {
        public static string SemGarantia()
        {
            var codigo_produto = "MLB1471424182";

            string semGarantia = "Sem garantia";

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "\r\n{\r\n   \"sale_terms\": \r\n[{" + $"\r\n\"id\": \"WARRANTY_TYPE\",\r\n\"value_name\": \"{semGarantia}\"\r\n" + "}]\r\n}\r\n", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.SemGarantia.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.SemGarantia.RootObject>(response.Content).ToString();
        }

    }
}
