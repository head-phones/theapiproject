using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Utilites
{
    public class APIClient
    {
        private string Endpoint { get; set; }
        private string APIKey { get; set; }
        public APIClient(string endpoint, string apiKey)
        {
            Endpoint = endpoint;
            APIKey = apiKey;
        }
        public async Task<string> GetAsync(string function)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    return await client.GetStringAsync($"{Endpoint}{function}");
                }
                catch (HttpRequestException)
                {

                }
            }
            return null;
        }

        public string Get(string function)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    return client.GetStringAsync($"{Endpoint}{function}").Result;
                }
                catch (HttpRequestException)
                {

                }
            }
            return null;
        }

        public string Post(string function, string data)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    var content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = client.PostAsync($"{Endpoint}{function}", content).Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException)
                {

                }
            }
            return null;
        }
        public async Task<HttpResponseMessage> PostAsync(string function, string data)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    return await client.PostAsync($"{Endpoint}{function}", new StringContent(data, Encoding.UTF8, "application/json"));
                }
                catch (HttpRequestException)
                {

                }
            }
            return null;
        }
        public async Task<HttpResponseMessage> PutAsync(string function, string data)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    return await client.PutAsync($"{Endpoint}{function}", new StringContent(data, Encoding.UTF8, "application/json"));
                }
                catch (HttpRequestException)
                {

                }
            }
            return null;
        }
        public string Put(string function, string data)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    var response = client.PutAsync($"{Endpoint}{function}", new StringContent(data, Encoding.UTF8, "application/json")).Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException)
                {

                }
            }
            return null;
        }
        public void Delete(string function)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
                try
                {
                    response = client.DeleteAsync(($"{Endpoint}{function}")).Result;
                }
                catch (HttpRequestException)
                {

                }
            }
        }
    }
}