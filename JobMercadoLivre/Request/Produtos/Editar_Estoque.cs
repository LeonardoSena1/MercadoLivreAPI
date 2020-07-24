using JobMercadoLivre.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos
{
    public class Editar_Estoque
    {
        public static string EditarQuantidadeEstoque()
        {
            var codigo_Produto = "MLB1471424182";

            int quantidade = 23;

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_Produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{" + $"\n    \"available_quantity\": {quantidade}\n" + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.EditarQuantidadeEstoque.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.EditarQuantidadeEstoque.RootObject>(response.Content).ToString();
        }

    }
}
