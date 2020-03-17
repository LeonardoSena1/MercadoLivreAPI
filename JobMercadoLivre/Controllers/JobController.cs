using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace JobMercadoLivre.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public void Autenticacao()
        {
            var Token = PostToken();
            //var Pedido = PedidoMLB();
            //var PedidoDeVendedor = Buscar_Os_Pedidos_De_Um_Vendedor();
            //var ConsultarPessoais = ConsultarDadosPessoais();   
            //var ChecarSaldo = ChecarSaldoEmConta();
            //var Orde = Ordem();
            //var NotaDeOrdem = NotasDeOrdem();
            //var PgtoAceitosPeloVendedor = PagamentosAceitosPeloVendedor();
            //var AddNovosProtudo = AddNovoProtudo();
            //var EditarPrecos = EditarPreco();
            //var EditaQuantidadeEstoque = EditarQuantidadeEstoque();
            //var AlterarVideos = AlterarVideo();
            //var AlterarCategoriaDoProdutos = AlterarCategoriaDoProduto();
            //var AlterarTituloAnuncios = AlterarTituloAnuncio(); 
            //var AlterarUnidadesEmarca = AlterarUnidadeEmarca();
            //var Semgarantia = SemGarantia();
            //var AlterarGarantiaFabricanteevendedor = AlterarGarantiaFabricanteEvendedor();
        }

        [HttpPost]
        public static string PostToken()
        {
            var client = new RestClient("https://api.mercadolibre.com/oauth/token?client_id=3726671596630096&client_secret=oCphpu7mdwFDQ5nuSigMVi0xPpkUwzCr&grant_type=client_credentials");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Length", "0");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Host", "api.mercadolibre.com");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
            IRestResponse response = client.Execute(request);

            var retorno = JsonConvert.DeserializeObject<Modelss.Token>(response.Content);


            return retorno.access_token;
        }

        #region GET pedido de produto com condigo
        //[HttpGet]
        //public ActionResult PedidoMLB()
        //{
        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1459710850?access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Postman-Token", "8ae652fe-29fa-4199-b960-6962a7be1070,e5b513a8-5975-4cc9-967e-d943583fc470");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<PedidoMLB.RootObject>(response.Content);

        //    return Ok(JsonConvert.DeserializeObject<PedidoMLB.RootObject>(response.Content));
        //}
        #endregion

        #region GET dos pedidos de um vendedor	
        //[HttpGet]
        //public static string Buscar_Os_Pedidos_De_Um_Vendedor()
        //{

        //    var client = new RestClient("https://api.mercadolibre.com/orders/search?seller=533461433&access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Modelss.Buscar_Os_Pedidos_De_Um_Vendedor.RootObject>(response.Content);            

        //    return JsonConvert.DeserializeObject<Modelss.Buscar_Os_Pedidos_De_Um_Vendedor.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region GET Consultar Dados Pessoais Usuarios
        //[HttpGet]
        //public static string ConsultarDadosPessoais()
        //{
        //    var client = new RestClient("https://api.mercadolibre.com/users/me?access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Modelss.ConsultarDadosPessoais.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Modelss.ConsultarDadosPessoais.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region GET checar saldo em Conta
        //[HttpGet]
        //public static string ChecarSaldoEmConta()
        //{
        //    var client = new RestClient("https://api.mercadolibre.com/users/533461433/mercadopago_account/balance?access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Postman-Token", "a0427864-7867-4b73-ab5c-fad705b1ac13,2b11d4b1-0640-4d6f-abe1-22a2919f1d88");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Modelss.ChecarSaldoEmConta.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Modelss.ChecarSaldoEmConta.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region GET Ordem
        //[HttpGet]
        //public static string Ordem()
        //{
        //    var client = new RestClient("https://api.mercadolibre.com/orders/2347791918?access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Modelss.Ordem.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Modelss.Ordem.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region GET Notas De ordem
        //[HttpGet]
        //public static string NotasDeOrdem()
        //{

        //    var client = new RestClient("https://api.mercadolibre.com/orders/2347791918/notes?access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<List<Modelss.NotasDeOrdem.RootObject>>(response.Content);


        //    return retorno[0].order_id.ToString();
        //}
        #endregion

        #region GET Obtém os métodos de pagamento aceitos pelo vendedor para cobrar.
        //[HttpGet]
        //public static string PagamentosAceitosPeloVendedor()
        //{
        //    var client = new RestClient("https://api.mercadolibre.com/users/533461433/accepted_payment_methods?access_token=" + PostToken());
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<List<Modelss.PagamentosAceitosPeloVendedor.RootObject>>(response.Content);

        //    return JsonConvert.DeserializeObject<Modelss.PagamentosAceitosPeloVendedor.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region POST de novo produto
        //public static string AddNovoProtudo()
        //{

        //    Modelss.AddNovoProduto.RootObject bodySend = new Modelss.AddNovoProduto.RootObject()
        //    {
        //        site_id = "MLB",
        //        title = "63645646112",
        //        category_id = "MLB204801",
        //        price = 9450,
        //        currency_id = "BRL",
        //        available_quantity = 1,

        //        buying_mode = "buy_it_now",
        //        listing_type_id = "gold_special",
        //        start_time = DateTime.Now.GetDateTimeFormats()[47],

        //        condition = "new",
        //        pictures = new List<AddNovoProduto.Picture>()
        //        {
        //            new AddNovoProduto.Picture()
        //            {
        //                id = "847243-MLB41005817997_032020",
        //                url = "http://mlb-s2-p.mlstatic.com/847243-MLB41005817997_032020-O.jpg",
        //                secure_url = "https://mlb-s2-p.mlstatic.com/847243-MLB41005817997_032020-O.jpg",
        //                size = "500x271",
        //                max_size = "500x271",
        //                quality = ""
        //            }
        //        },
        //        video_id = "YfBWoZ30K_A",

        //        non_mercado_pago_payment_methods = new List<object>() { },

        //        shipping = new AddNovoProduto.Shipping()
        //        {
        //            mode = "me2",
        //            free_methods = new List<AddNovoProduto.FreeMethod>()
        //            {
        //                new AddNovoProduto.FreeMethod()
        //                {
        //                    id = 100009,
        //                    rule = new AddNovoProduto.Rule()
        //                    {
        //                        free_mode = "country",
        //                    }
        //                }
        //            },
        //            tags = new List<string>()
        //            {
        //                "mandatory_free_shipping"
        //            },

        //            local_pick_up = false,
        //            free_shipping = true,
        //            logistic_type = "drop_off",
        //            store_pick_up = false
        //        },


        //        seller_address = new AddNovoProduto.SellerAddress()
        //        {
        //            city = new AddNovoProduto.City()
        //            {
        //                id = "BR-SP-44",
        //                name = "São Paulo"
        //            },

        //            state = new AddNovoProduto.State()
        //            {
        //                id = "BR-SP",
        //                name = "São Paulo"
        //            },

        //            country = new AddNovoProduto.Country()
        //            {
        //                id = "BR",
        //                name = "Brasil"
        //            },

        //            search_location = new AddNovoProduto.SearchLocation()
        //            {
        //                neighborhood = new AddNovoProduto.Neighborhood()
        //                {
        //                    id = "TUxCQlRBVDgzMjY",
        //                    name = "Tatuapé"
        //                },

        //                city = new AddNovoProduto.City2()
        //                {
        //                    id = "TUxCQ1NQLTQzMzc",
        //                    name = "São Paulo Zona Leste"
        //                },

        //                state = new AddNovoProduto.State2()
        //                {
        //                    id = "TUxCUFNBT085N2E4",
        //                    name = "São Paulo"
        //                }
        //            },

        //            latitude = -23.549086,
        //            longitude = -46.562477,
        //        },

        //        location = new AddNovoProduto.Location() { },
        //        coverage_areas = new List<object>() { },
        //        attributes = new List<AddNovoProduto.Attribute>()
        //        {
        //            new AddNovoProduto.Attribute()
        //            {
        //                id = "BRAND",
        //                name = "Marca",
        //                value_name = "Nao tem marca teste C#",
        //                values = new List<AddNovoProduto.Value>()
        //                {
        //                    new AddNovoProduto.Value()
        //                    {
        //                        name = "Nao tem marca teste C#"
        //                    }
        //                },
        //                attribute_group_id = "OTHERS",
        //                attribute_group_name = "Outros"
        //            },

        //            new AddNovoProduto.Attribute()
        //            {
        //                id = "ITEM_CONDITION",
        //                name = "Condição do item",
        //                value_id = "2230284",
        //                value_name = "Novo",
        //                values = new List<AddNovoProduto.Value>()
        //                {
        //                    new AddNovoProduto.Value()
        //                    {
        //                        id = "2230284",
        //                        name = "Novo",
        //                    }
        //                },

        //                attribute_group_id = "OTHERS",
        //                attribute_group_name = "Outros",
        //            },
        //            new AddNovoProduto.Attribute()
        //            {
        //                id = "UNITS_PER_PACKAGE",
        //                name = "Unidades por pacote",
        //                value_name = "100",
        //                values = new List<AddNovoProduto.Value>()
        //                {
        //                    new AddNovoProduto.Value()
        //                    {
        //                        name = "100",
        //                    }
        //                }
        //            }
        //        },


        //        variations = new List<object>() { },

        //        status = "closed",

        //        tags = new List<string>()
        //        {
        //            "good_quality_picture",
        //            "immediate_payment",
        //            "cart_eligible"
        //        },

        //        warranty = "Garantia do Vendendor: 1 ano",

        //        domain_id = "MLB-TOOTHPASTES",


        //        automatic_relist = false,

        //        catalog_listing = false
        //    };


        //    var client = new RestClient("https://api.mercadolibre.com/items?access_token=" + PostToken());
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "5122");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", JsonConvert.SerializeObject(bodySend, Formatting.None,
        //                    new JsonSerializerSettings
        //                    {
        //                        NullValueHandling = NullValueHandling.Ignore
        //                    }), ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);


        //    return JsonConvert.DeserializeObject<Modelss.AddNovoProduto>(response.Content).ToString();
        //}
        #endregion

        #region PUT Editar Preco
        //[HttpPut]
        //public static string EditarPreco()
        //{
        //    double Preco = 1336;

        //    var client1 = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request1 = new RestRequest(Method.PUT);
        //    request1.AddHeader("cache-control", "no-cache");
        //    request1.AddHeader("Connection", "keep-alive");
        //    request1.AddHeader("Content-Length", "22");
        //    request1.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request1.AddHeader("Host", "api.mercadolibre.com");
        //    request1.AddHeader("Cache-Control", "no-cache");
        //    request1.AddHeader("Accept", "*/*");
        //    request1.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request1.AddHeader("Content-Type", "application/json");
        //    request1.AddParameter("undefined", "{" + $"\r\n  \"price\": { Preco } \r\n" + "}", ParameterType.RequestBody);
        //    IRestResponse response1 = client1.Execute(request1);

        //    var r = JsonConvert.DeserializeObject<Models.EditarPreco.RootObject>(response1.Content);

        //    return JsonConvert.DeserializeObject<Models.EditarPreco.RootObject>(response1.Content).ToString();
        //}
        #endregion

        #region PUT Editar Quantidade no estoque
        //[HttpPut]
        //public static string EditarQuantidadeEstoque()
        //{
        //    int quantidade = 23;

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "32");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "{" + $"\n    \"available_quantity\": {quantidade}\n" + "}", ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.EditarQuantidadeEstoque.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.EditarQuantidadeEstoque.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region PUT Alterar video do Youtube
        //[HttpPut]
        //public static string AlterarVideo()
        //{
        //    string Video = "yJTsA4hC_fw";

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "37");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "\r\n  {" + $"\r\n \"video_id\": \"{Video}\"\r\n" + "}\r\n", ParameterType.RequestBody);

        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.AlterarVideoYouTube.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.AlterarVideoYouTube.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region PUT Alterar a categoria do produto
        //[HttpPut]
        //public static string AlterarCategoriaDoProduto()
        //{
        //    string CategoriaNova = "MLB204801";

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "34");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "{" + $"\n    \"category_id\": \"{CategoriaNova}\"\n" + "}", ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.AlterarCategoriaDoProduto.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.AlterarCategoriaDoProduto.RootObject>(response.Content).ToString();
        //}

        #endregion

        #region PUT Alterar o Titulo do anuncio
        //[HttpPut]
        //public static string AlterarTituloAnuncio()
        //{
        //    string tituloNovo = "Teste C#";

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "31");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "{" + $"\r\n    \"title\": \"{tituloNovo} \"\r\n" + "}", ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.EditarTituloAnuncio.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.EditarTituloAnuncio.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region PUT Alterar unidade por pacote e Marca
        //[HttpPut]
        //public static string AlterarUnidadeEmarca()
        //{
        //    string Marca = "Marca do C#";
        //    int UnidadePorPacote = 50;

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "283");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "{ \n\"attributes\": [\n   {" + $"\n \"id\": \"BRAND\",\n\"name\": \"Marca\",\n  \"value_name\": \"{Marca}\"\n" + "}, \n  " +
        //        "{" + $"\n \"id\": \"UNITS_PER_PACKAGE\",\n\"name\": \"Unidades por pacote\",\n \"value_name\": \"{UnidadePorPacote}\"\n" + "}\n    ]\n}"
        //        , ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.AlterarUnidadesEmarcas.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.AlterarUnidadesEmarcas.RootObject>(response.Content).ToString();
        //}

        #endregion

        #region PUT Alterar Garantia ( Sem Garantia )
        //[HttpPut]
        //public static string SemGarantia()
        //{
        //    string semGarantia = "Sem garantia";

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "109");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "\r\n{\r\n   \"sale_terms\": \r\n[{" + $"\r\n\"id\": \"WARRANTY_TYPE\",\r\n\"value_name\": \"{semGarantia}\"\r\n" + "}]\r\n}\r\n", ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.SemGarantia.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.SemGarantia.RootObject>(response.Content).ToString();
        //}
        #endregion

        #region PUT Alterar Garantia ( Garantia do fabricante e Garantia do vendedor )
        //[HttpPut]
        //public static string AlterarGarantiaFabricanteEvendedor()
        //{
        //    var TipoDeGarantia = "Garantia do fabricante"; //Garantia de fabrica ou Garantia do vendedor
        //    int QuantoTempo = 2;
        //    string DMA = "dias"; // dias, meses, anos

        //    var client = new RestClient("https://api.mercadolibre.com/items/MLB1471424182?access_token=" + PostToken());
        //    var request = new RestRequest(Method.PUT);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("Connection", "keep-alive");
        //    request.AddHeader("Content-Length", "296");
        //    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        //    request.AddHeader("Host", "api.mercadolibre.com");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Accept", "*/*");
        //    request.AddHeader("User-Agent", "PostmanRuntime/7.23.0");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("undefined", "{\r\n   \"sale_terms\": \r\n   [{" + $"\r\n       \"id\": \"WARRANTY_TYPE\",\r\n       \"value_id\": \"2230279\",\r\n       \"name\": \"Tipo de garantia\",\r\n       \"value_name\": \"{TipoDeGarantia}\"\r\n" + "},{" + $"\r\n   \t\r\n   \t\t\"id\": \"WARRANTY_TIME\",\r\n        \"name\": \"Tempo de garantia\",\r\n        \"value_name\": \"{QuantoTempo} {DMA}\"\r\n" + "}]\r\n}\r\n", ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    var retorno = JsonConvert.DeserializeObject<Models.GarantiaFabricanteEvendedor.RootObject>(response.Content);

        //    return JsonConvert.DeserializeObject<Models.GarantiaFabricanteEvendedor.RootObject>(response.Content).ToString();
        //}
        #endregion
    }
}