using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Request
{
    public class Token
    {
        public static string TokenML()
        {
            var client_id = "3726671596630096";
            var client_secret = "oCphpu7mdwFDQ5nuSigMVi0xPpkUwzCr";
            var grant_type = "client_credentials";

            var client = new RestClient("https://api.mercadolibre.com/oauth/token?client_id=" + $"{client_id}" + "&client_secret=" + $"{client_secret}&grant_type=" + $"{grant_type}");
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Modelss.Token>(response.Content);

            return retorno.access_token;
        }


        public static string Gerar_Conta_teste()
        {
            // Só pode ser gerado 10 conta teste.
            //Usuario teste: test_user_25051599 @testuser.com
            //Senha: qatest6357

            //Usuario de compra teste: test_user_62363484@testuser.com
            //Senha: qatest2130


            var client = new RestClient("https://api.mercadolibre.com/users/test_user?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n   \t\"site_id\":\"MLB\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }
    }
}
