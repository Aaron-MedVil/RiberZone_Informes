using RestSharp;
using rz_inf_0._1.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace rz_inf_0._1.Logic {
    class RestSharp {

        const string clientURL = "https://localhost:5001/api/";
        RestClient client = null;

        /// <summary>Constructor de la clase</summary>
        public RestSharp() {
            client = new RestClient(clientURL);
        }

        /// <summary>Obtiene los datos de los productos del servidor REST</summary>
        /// <returns>Lista con los datos de los productos</returns>
        public List<ProductTemplate> getProductTemplate() {
            var request = new RestRequest("ProductTemplate/GetProductTemplate", Method.GET);
            var response = client.Execute<List<ProductTemplate>>(request);
            return response.Data;
        }

        public void getInvoices() { }

        /// <summary>Obtiene los datos de los pedidos del servidor REST</summary>
        /// <returns>Lista con los datos de los pedidos</returns>
        public List<OrderSale> getOrders() {
            var request = new RestRequest("SaleOrder/GetSaleOrders", Method.GET);
            var response = client.Execute<List<OrderSale>>(request);
            return response.Data;
        }
    }
}
