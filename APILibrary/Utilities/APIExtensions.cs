using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Utilites
{
    public class ApiExtensions
    {
        public APIClient Client;
        public ApiExtensions(string endpoint, string apiKey)
        {
            Client = new APIClient(endpoint, apiKey);
        }

        public T Get<T>(string function)
        {
            var response = Client.Get(!function.StartsWith("/") ? $"/{function}" : function);
            return JsonConvert.DeserializeObject<T>(response);
        }

        public async Task<T> GetAsync<T>(string function)
        {
            var response = await Client.GetAsync(!function.StartsWith("/") ? $"/{function}" : function);
            return JsonConvert.DeserializeObject<T>(response);
        }
        public T Add<T>(string function, T data)
        {
            var response = Client.Post(!function.StartsWith("/") ? $"/{function}" : function, JsonConvert.SerializeObject(data));
            return JsonConvert.DeserializeObject<T>(response);
        }
        public T Update<T>(string function, T data)
        {
            var response = Client.Put(!function.StartsWith("/") ? $"/{function}" : function, JsonConvert.SerializeObject(data));
            return JsonConvert.DeserializeObject<T>(response);
        }
        public IEnumerable<T> GetAll<T>(string function)
        {
            var response = Client.Get(!function.StartsWith("/") ? $"/{function}" : function);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(response);
        }
        public async Task<IEnumerable<T>> GetAllAsync<T>(string function)
        {
            var response = await Client.GetAsync(!function.StartsWith("/") ? $"/{function}" : function);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(response);
        }
        public void Delete(string function)
        {
            Client.Delete(!function.StartsWith("/") ? $"/{function}" : function);
        }

    }
}