using JobMercadoLivre.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos
{
    public class Editar_Unidade_Marca
    {
        public static string AlterarUnidadeEmarca()
        {
            var codigo_produto = "MLB1471424182";

            string Marca = "Marca do C#";
            int UnidadePorPacote = 50;

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{ \n\"attributes\": [\n   {" + $"\n \"id\": \"BRAND\",\n\"name\": \"Marca\",\n  \"value_name\": \"{Marca}\"\n" + "}, \n  " +
                "{" + $"\n \"id\": \"UNITS_PER_PACKAGE\",\n\"name\": \"Unidades por pacote\",\n \"value_name\": \"{UnidadePorPacote}\"\n" + "}\n    ]\n}"
                , ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.AlterarUnidadesEmarcas.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.AlterarUnidadesEmarcas.RootObject>(response.Content).ToString();
        }

    }
}
