using Application.UI.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Application.UI.Components
{
    public partial class BookGetById
    {
        [Inject]
        protected IHttpClientFactory ClientFactory { get; set; }
        public string FoundedId { get; set; }
        public Book Book { get; set; }
        public string ErrorString { get; set; }
        public async Task GetByIdAsync(int id)
        {
            var client = ClientFactory.CreateClient();
            var url = "https://localhost:44304/get/" + FoundedId;
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

    }
}
