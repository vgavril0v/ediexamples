using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Parser2.LenovoApi
{
    public static class LenovoInventoryClient
    {
        public static async Task<InventoryResponse> PostInvetoryData(InventoryData data)
        {
            var client = new HttpClient();

            var uri = new Uri(
                "https://api-test.lenovo.com/locgateway/v2/inventory_recon/stock");

            var content = new StringContent(JsonConvert.SerializeObject(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var token = await LenovoTokenClient.GetTokenFromCache();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var res = await (await client.PostAsync(uri, content))
                .Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InventoryResponse>(res);
        }
    }


    public class InventoryData
    {
        public string user_name { get; set; }
        public InventoryDataLine[] data { get; set; }
    }

    public class InventoryDataLine
    {
        public string material_number { get; set; }
        public string plant { get; set; }
        public string location { get; set; }
        public string create_date { get; set; }
        public string create_time { get; set; }
        public string timezone { get; set; }
        public string quantity { get; set; }
        public string unit_of_measurement { get; set; }
    }


    public class InventoryResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public InventoryResultLine[] data { get; set; }
    }

    public class InventoryResultLine
    {
        public string material_number { get; set; }
        public string is_valid { get; set; }
        public string message { get; set; }
    }

}