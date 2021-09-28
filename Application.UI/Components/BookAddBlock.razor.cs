using Application.UI.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.UI.Components
{
    public partial class BookAddBlock
    {
        [Inject]
        protected IHttpClientFactory ClientFactory { get; set; }
        
        public string NameOfNewBook { get; set; }
        public string PriceOfNewBook { get; set; }
        public string ErrorString { get; set; }

        public async Task AddBookAsync(string name, double price)
        {
            var client = ClientFactory.CreateClient();
            var url = "https://localhost:44304/add/" + $"{name}/" + price.ToString();
            var request = new HttpRequestMessage(HttpMethod.Post, url);
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
    }
}
