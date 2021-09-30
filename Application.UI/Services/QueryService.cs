using Application.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Application.UI.Services
{
    public class QueryService
    {
        protected IHttpClientFactory ClientFactory { get; set; }
        public string test;
        public string ErrorString { get; set; }
        public Book[] Books { get; set; }
        public Book Book { get; set; }

        protected readonly Uri Uri = new Uri("https://localhost:44304/api/books");

        public QueryService(IHttpClientFactory clientFactory)
        {
            ClientFactory = clientFactory;
        }

        public async Task AddBookAsync(string name, string price)
        {
            var client = ClientFactory.CreateClient();
            var jsonString = JsonConvert.SerializeObject(new BookViewModel(name, price));
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            try
            {
                await client.PostAsync(Uri, content);
                ErrorString = null;
            }
            catch (Exception ex)
            {
                ErrorString = $"There was an error getting out book: {ex.Message}";
            }
        }
        public async Task DeleteByIdAsync(string id)
        {
            var client = ClientFactory.CreateClient();
            var url = Uri + $"/{id}";

            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            try
            {
                await client.SendAsync(request);
                ErrorString = null;
            }
            catch (Exception ex)
            {
                ErrorString = $"There was an error getting out book: {ex.Message}";
            }
        }
        public async Task GetByIdAsync(string id)
        {
            var client = ClientFactory.CreateClient();
            var url = Uri + $"/{id}";
            try
            {
                Book = await client.GetFromJsonAsync<Book>(url);
                ErrorString = null;
            }
            catch (Exception ex)
            {
                ErrorString = $"There was an error getting out book: {ex.Message}";
            }
        }
    
        public async Task GetAll()
        {
            var client = ClientFactory.CreateClient();

            try
            {
                Books = await client.GetFromJsonAsync<Book[]>($"{Uri}/all");
                ErrorString = null;
            }
            catch (Exception ex)
            {
                ErrorString = $"There was an error getting out book: {ex.Message}";
            }
        }

        public async Task UpdateByIdAsync(string id, string name, string price)
        {
            var client = ClientFactory.CreateClient();
            //var jsonString = JsonConvert.SerializeObject(new BookWithIdViewModel(id, name, price));
            var jsonString = "{\"id\":8,\"name\":UPDATED8,\"price\":8888888}";
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            test = jsonString.ToString();
            try
            {
                await client.PutAsync(Uri, content);
                ErrorString = null;
            }
            catch (Exception ex)
            {
                ErrorString = $"There was an error getting out book: {ex.Message}";
            }
        }
    }
}
