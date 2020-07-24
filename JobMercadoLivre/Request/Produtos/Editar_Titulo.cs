using JobMercadoLivre.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos
{
    public class Editar_Titulo
    {
        public static string AlterarTituloAnuncio()
        {
            var codigo_produto = "MLB1471424182";

            string tituloNovo = "Teste C#";

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{" + $"\r\n    \"title\": \"{tituloNovo} \"\r\n" + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.EditarTituloAnuncio.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.EditarTituloAnuncio.RootObject>(response.Content).ToString();
        }

    }
}
