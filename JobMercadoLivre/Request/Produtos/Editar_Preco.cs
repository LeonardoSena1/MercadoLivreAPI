using JobMercadoLivre.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos
{
    public class Editar_Preco
    {
        public static string EditarPreco()
        {
            var codigo_codigoProduto = "MLB1471424182";
            double Preco = 1336;

            var client1 = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_codigoProduto}" + "?access_token=" + Token.TokenML());
            var request1 = new RestRequest(Method.PUT);
            request1.AddHeader("Content-Type", "application/json");
            request1.AddParameter("undefined", "{" + $"\r\n  \"price\": { Preco } \r\n" + "}", ParameterType.RequestBody);
            IRestResponse response1 = client1.Execute(request1);

            var r = JsonConvert.DeserializeObject<Models.EditarPreco.RootObject>(response1.Content);

            return JsonConvert.DeserializeObject<Models.EditarPreco.RootObject>(response1.Content).ToString();
        }

    }
}
