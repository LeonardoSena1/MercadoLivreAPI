using JobMercadoLivre.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos
{
    public class Editar_Video
    {
        public static string AlterarVideo()
        {
            var codigo_Produto = "MLB1471424182";
            string Video = "yJTsA4hC_fw";

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_Produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "\r\n  {" + $"\r\n \"video_id\": \"{Video}\"\r\n" + "}\r\n", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.AlterarVideoYouTube.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.AlterarVideoYouTube.RootObject>(response.Content).ToString();
        }

    }
}
