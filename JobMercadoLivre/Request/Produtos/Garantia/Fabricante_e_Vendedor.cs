using JobMercadoLivre.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request.Produtos.Garantia
{
    public class Fabricante_e_Vendedor
    {
        public static string AlterarGarantiaFabricanteEvendedor()
        {
            var codigo_Produto = "MLB1471424182";

            var TipoDeGarantia = "Garantia do fabricante"; //Garantia de fabrica ou Garantia do vendedor
            int QuantoTempo = 2;
            string DMA = "dias"; // dias, meses, anos

            var client = new RestClient("https://api.mercadolibre.com/items/" + $"{codigo_Produto}" + "?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n   \"sale_terms\": \r\n   [{" + $"\r\n       \"id\": \"WARRANTY_TYPE\",\r\n       \"value_id\": \"2230279\",\r\n       \"name\": \"Tipo de garantia\",\r\n       \"value_name\": \"{TipoDeGarantia}\"\r\n" + "},{" + $"\r\n   \t\r\n   \t\t\"id\": \"WARRANTY_TIME\",\r\n        \"name\": \"Tempo de garantia\",\r\n        \"value_name\": \"{QuantoTempo} {DMA}\"\r\n" + "}]\r\n}\r\n", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Models.GarantiaFabricanteEvendedor.RootObject>(response.Content);

            return JsonConvert.DeserializeObject<Models.GarantiaFabricanteEvendedor.RootObject>(response.Content).ToString();
        }

    }
}
