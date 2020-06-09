using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Parser2.LenovoApi
{
    public class LenovoTokenClient
    {
        private static IMemoryCache _cache = new MemoryCache(new MemoryCacheOptions
        {

        });



        public static async Task<string> GetTokenFromCache(string clientId, string secret) =>
            await _cache.GetOrCreateAsync(
                key: "Token_" + clientId + "_" + secret,
                factory: async entry =>
                {
                    entry.SetAbsoluteExpiration(new TimeSpan(0, 0, 5, 0));

                    var cl = new HttpClient();
                    cl.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            Encoding.UTF8.GetBytes(clientId + ":" + secret)));

                    var content = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("grant_type", "client_credentials")
                    });

                    var result = await cl.PostAsync("https://cn-api-test.lenovo.com/uat/token", content);

                    return JsonConvert.DeserializeObject<Token>(await result.Content.ReadAsStringAsync()).access_token;
                });

    }
}