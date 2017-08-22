using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ServiceProxyBase
    {
        readonly string _username;
        readonly string _password;
        public string Token { get; set; }
        private string _baseUrl;

        public ServiceProxyBase(string baseUrl, string token = "")
        {
            Token = token;
            _baseUrl = baseUrl;
        }

        public ServiceProxyBase(string baseUrl, string username, string password)
        {
            _username = username;
            _password = password;
            _baseUrl = baseUrl;
        }

        public RestRequest BuildGetRequest(string url, DataFormat requestFormat)
        {
            return new RestRequest(url, Method.GET);
        }

        public RestRequest BuildPostRequest(string url, object data, DataFormat requestFormat)
        {
            var req = new RestRequest(url, Method.POST) { RequestFormat = requestFormat };
            req.AddBody(data);
            return req;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(_baseUrl);

            if (!string.IsNullOrWhiteSpace(Token))
                request.AddHeader("Authorization", Token); // used on every request

            var response = client.Execute(request);

            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
               
                var data = JsonConvert.DeserializeObject<T>(response.Content);
                return data;
            }
            
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response. Check inner details for more info.";
                var appException = new ApplicationException(message, response.ErrorException);
                throw appException;
            }
            return default(T);
        }
        private static string GetCallDetails(string uri)
        {
            StringBuilder sb = new StringBuilder();
            var u = new Uri(uri);
            sb.Append(u.AbsolutePath);
            if (u.Query.StartsWith("?"))
            {
                var queryParameters = u.Query.Substring(1).Split('&');
                foreach (var p in queryParameters)
                {
                    if (!(p.ToLower().StartsWith("api") || p.ToLower().StartsWith("nonce")))
                    {
                        var kv = p.Split('=');
                        if (kv.Length == 2)
                        {
                            if (sb.Length != 0)
                            {
                                sb.Append(", ");
                            }

                            sb.Append(kv[0]).Append(" = ").Append(kv[1]);
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}
