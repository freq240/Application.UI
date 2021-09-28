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
    public partial class BookTableData
    {
        [Inject]
        protected IHttpClientFactory ClientFactory { get; set; }

        public Book[] books;
        public string errorString;



        protected override async Task OnInitializedAsync()
        {

            var client = ClientFactory.CreateClient();

            try
            {
                books = await client.GetFromJsonAsync<Book[]>("https://localhost:44304/get/all");
                errorString = null;
            }
            catch(Exception ex)
            {
                errorString = $"There was an error getting out book: {ex.Message}";
            }
        }

        public async Task UpdateAsync()
        {
            await OnInitializedAsync();
        }
    }
}


