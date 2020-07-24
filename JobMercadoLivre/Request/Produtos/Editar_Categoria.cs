using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos
{
    public class Editar_Categoria
    {
        public static string AlterarCategoriaDoProduto()
        {
            var codigo_Produto = "MLB1471424182";

            string CategoriaNova = "MLB204801";

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_Produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{" + $"\n    \"category_id\": \"{CategoriaNova}\"\n" + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.AlterarCategoriaDoProduto.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.AlterarCategoriaDoProduto.RootObject>(response.Content).ToString();
        }

    }
}
