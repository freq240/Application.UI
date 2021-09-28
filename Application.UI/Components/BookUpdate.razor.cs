using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Application.UI.Components
{
    public partial class BookUpdate
    {
        [Inject]
        protected IHttpClientFactory ClientFactory { get; set; }
        public string UpdatedId { get; set; }
        public string NewName { get; set; }
        public string NewPrice { get; set; }
        public string ErrorString { get; set; }
        public async Task UpdateByIdAsync(int id, string name, double price)
        {
            var client = ClientFactory.CreateClient();
            var url = "https://localhost:44304/update/" + id.ToString() + $"/{name}/" + price.ToString();
            var request = new HttpRequestMessage(HttpMethod.Put, url);
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
