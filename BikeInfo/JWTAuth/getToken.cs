using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace BikeInfo.JWTAuth
{
    public class getToken
    {
        public getToken()
        {
        }
		public static string getJWT()
        {
            HttpClient client = new HttpClient();
            //this is the API Gateway address
            client.BaseAddress = new Uri("http://localhost:9000");
            client.DefaultRequestHeaders.Clear();

            //TODO: these should be in a config file
            var res2 = client.GetAsync("/appdjwt?name=apiLogin&pwd=sinB@d123").Result;

            dynamic jwt = JsonConvert.DeserializeObject(res2.Content.ReadAsStringAsync().Result);

            return jwt.access_token;
        }
    }
}
