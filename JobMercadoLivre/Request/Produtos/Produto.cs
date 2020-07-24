using JobMercadoLivre.Controllers;
using JobMercadoLivre.Modelss;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace JobMercadoLivre.Request.Produtos
{
    public class Produto
    {
        public static string AddNovoProtudo()
        {

            AddNovoProduto.RootObject bodySend = new AddNovoProduto.RootObject();
            bodySend.site_id = "MLB";
            bodySend.title = "Teste Criar";
            bodySend.category_id = "MLB204801";
            bodySend.price = 300;
            bodySend.currency_id = "BRL";
            bodySend.available_quantity = 1;
            bodySend.buying_mode = "buy_it_now";
            bodySend.listing_type_id = "gold_special";
            bodySend.start_time = "";
            bodySend.condition = "new";

            bodySend.pictures = new List<AddNovoProduto.Picture>();
            var picture1 = new AddNovoProduto.Picture();
            picture1.id = "847243-MLB41005817997_032020";
            picture1.url = "http://mlb-s2-p.mlstatic.com/847243-MLB41005817997_032020-O.jpg";
            picture1.secure_url = "https://mlb-s2-p.mlstatic.com/847243-MLB41005817997_032020-O.jpg";
            picture1.size = "500x271";
            picture1.max_size = "500x271";
            picture1.quality = "";
            bodySend.pictures.Add(picture1);

            bodySend.video_id = "YfBWoZ30K_A";
            bodySend.non_mercado_pago_payment_methods = new List<object>();
            bodySend.shipping = new AddNovoProduto.Shipping();

            bodySend.shipping.mode = "me2";
            bodySend.shipping.local_pick_up = false;
            bodySend.shipping.free_shipping = true;
            bodySend.shipping.logistic_type = "drop_off";
            bodySend.shipping.store_pick_up = false;

            var free_methods = new List<AddNovoProduto.FreeMethod>();
            var free_method = new AddNovoProduto.FreeMethod();
            free_method.id = 100009;
            free_method.rule = new AddNovoProduto.Rule();
            free_method.rule.free_mode = "country";
            free_methods.Add(free_method);

            bodySend.shipping.tags = new List<string>();
            bodySend.shipping.tags.Add("mandatory_free_shipping");

            var seller_address = new AddNovoProduto.SellerAddress();
            seller_address.latitude = -23.549086;
            seller_address.longitude = -46.562477;

            var city = new AddNovoProduto.City();
            city.id = "BR-SP-44";
            city.name = "Guarulhos";

            var state = new AddNovoProduto.State();
            state.id = "BR-SP";
            state.name = "Sao paulo";

            var country = new AddNovoProduto.Country();
            country.id = "BR";
            country.name = "Brasil";

            var location = new AddNovoProduto.Location();
            var coverage_areas = new List<object>();

            var attributes = new List<AddNovoProduto.Attribute>();
            var attribute = new AddNovoProduto.Attribute();
            attribute.id = "BRAND";
            attribute.name = "Marca";
            attribute.attribute_group_id = "OTHERS";
            attribute.attribute_group_name = "Outros";
            attribute.value_name = "Marca TEste";
            attribute.values = new List<AddNovoProduto.Value>();
            var Value = new AddNovoProduto.Value();
            Value.name = "Marca teste";
            attribute.values.Add(Value);
            attributes.Add(attribute);

            var attribute1 = new AddNovoProduto.Attribute();
            attribute1.id = "ITEM_CONDITION";
            attribute1.name = "Condição do item";
            attribute1.value_id = "2230284";
            attribute1.value_name = "Usado";
            attribute1.attribute_group_id = "OTHERS";
            attribute1.attribute_group_name = "Outros";
            attribute1.values = new List<AddNovoProduto.Value>();
            var attribute1List = new AddNovoProduto.Value();
            attribute1List.id = "2230284";
            attribute1List.name = "Usado";
            attribute1.values.Add(attribute1List);
            attributes.Add(attribute1);

            var attribute2 = new AddNovoProduto.Attribute();
            attribute2.id = "";
            attribute2.name = "12";
            attribute2.value_name = "52";
            attribute2.values = new List<AddNovoProduto.Value>();
            var attribute2List = new AddNovoProduto.Value();
            attribute2List.name = "1";
            attribute2.values.Add(attribute2List);
            attributes.Add(attribute2);

            bodySend.variations = new List<object>();

            bodySend.status = "closed";
            bodySend.tags = new List<string>();
            bodySend.tags.Add("good_quality_picture");
            bodySend.tags.Add("immediate_payment");
            bodySend.tags.Add("cart_eligible");
            bodySend.domain_id = "MLB-TOOTHPASTES";
            bodySend.automatic_relist = false;
            bodySend.catalog_listing = false;


            var client = new RestClient("https://api.mercadolibre.com/items?access_token=" + Token.TokenML());
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", JsonConvert.SerializeObject(bodySend, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            }), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);


            return JsonConvert.DeserializeObject<Modelss.AddNovoProduto>(response.Content).ToString();
        }

    }
}
