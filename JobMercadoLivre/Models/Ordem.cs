﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMercadoLivre.Modelss
{
    public class Ordem
    {
        public class Purchase
        {
            public long id { get; set; }
            public DateTime date_created { get; set; }
            public bool fulfilled { get; set; }
            public string rating { get; set; }
            public string status { get; set; }
        }

        public class Sale
        {
            public long id { get; set; }
            public DateTime date_created { get; set; }
            public bool fulfilled { get; set; }
            public string rating { get; set; }
            public string status { get; set; }
        }

        public class Feedback
        {
            public Purchase purchase { get; set; }
            public Sale sale { get; set; }
        }

        public class OrderRequest
        {
            public object @return { get; set; }
            public object change { get; set; }
        }

        public class Coupon
        {
            public object id { get; set; }
            public int amount { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public string title { get; set; }
            public string category_id { get; set; }
            public object variation_id { get; set; }
            public object seller_custom_field { get; set; }
            public List<object> variation_attributes { get; set; }
            public string warranty { get; set; }
            public string condition { get; set; }
            public object seller_sku { get; set; }
        }

        public class OrderItem
        {
            public Item item { get; set; }
            public int quantity { get; set; }
            public int unit_price { get; set; }
            public int full_unit_price { get; set; }
            public string currency_id { get; set; }
            public object manufacturing_days { get; set; }
            public int sale_fee { get; set; }
            public string listing_type_id { get; set; }
        }

        public class Collector
        {
            public int id { get; set; }
        }

        public class AtmTransferReference
        {
            public object company_id { get; set; }
            public string transaction_id { get; set; }
        }

        public class Payment
        {
            public long id { get; set; }
            public long order_id { get; set; }
            public int payer_id { get; set; }
            public Collector collector { get; set; }
            public object card_id { get; set; }
            public string site_id { get; set; }
            public string reason { get; set; }
            public string payment_method_id { get; set; }
            public string currency_id { get; set; }
            public int installments { get; set; }
            public string issuer_id { get; set; }
            public AtmTransferReference atm_transfer_reference { get; set; }
            public object coupon_id { get; set; }
            public object activation_uri { get; set; }
            public string operation_type { get; set; }
            public string payment_type { get; set; }
            public List<string> available_actions { get; set; }
            public string status { get; set; }
            public object status_code { get; set; }
            public string status_detail { get; set; }
            public int transaction_amount { get; set; }
            public int taxes_amount { get; set; }
            public int shipping_cost { get; set; }
            public int coupon_amount { get; set; }
            public int overpaid_amount { get; set; }
            public double total_paid_amount { get; set; }
            public double installment_amount { get; set; }
            public object deferred_period { get; set; }
            public DateTime date_approved { get; set; }
            public string authorization_code { get; set; }
            public object transaction_order_id { get; set; }
            public DateTime date_created { get; set; }
            public DateTime date_last_modified { get; set; }
        }

        public class Shipping
        {
            public string status { get; set; }
        }

        public class BillingInfo
        {
            public object doc_type { get; set; }
            public object doc_number { get; set; }
        }

        public class Buyer
        {
            public int id { get; set; }
            public string nickname { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public BillingInfo billing_info { get; set; }
        }

        public class Phone
        {
            public string area_code { get; set; }
            public string extension { get; set; }
            public string number { get; set; }
            public bool verified { get; set; }
        }

        public class AlternativePhone
        {
            public string area_code { get; set; }
            public string extension { get; set; }
            public string number { get; set; }
        }

        public class Seller
        {
            public int id { get; set; }
            public string nickname { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public Phone phone { get; set; }
            public AlternativePhone alternative_phone { get; set; }
        }

        public class Taxes
        {
            public object amount { get; set; }
            public object currency_id { get; set; }
        }

        public class RootObject
        {
            public long id { get; set; }
            public DateTime date_created { get; set; }
            public DateTime date_closed { get; set; }
            public DateTime last_updated { get; set; }
            public object manufacturing_ending_date { get; set; }
            public Feedback feedback { get; set; }
            public List<object> mediations { get; set; }
            public object comments { get; set; }
            public object pack_id { get; set; }
            public object pickup_id { get; set; }
            public OrderRequest order_request { get; set; }
            public bool fulfilled { get; set; }
            public int total_amount { get; set; }
            public int total_amount_with_shipping { get; set; }
            public int paid_amount { get; set; }
            public Coupon coupon { get; set; }
            public DateTime expiration_date { get; set; }
            public List<OrderItem> order_items { get; set; }
            public string currency_id { get; set; }
            public List<Payment> payments { get; set; }
            public Shipping shipping { get; set; }
            public string status { get; set; }
            public object status_detail { get; set; }
            public List<string> tags { get; set; }
            public Buyer buyer { get; set; }
            public Seller seller { get; set; }
            public Taxes taxes { get; set; }
        }

    }
}
