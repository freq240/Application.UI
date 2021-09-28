using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Application.UI.Components
{
    public partial class BookDelete
    {
        [Inject]
        protected IHttpClientFactory ClientFactory { get; set; }
        public string DeletedId { get; set; }
        public string ErrorString { get; set; }
        public async Task DeleteByIdAsync(int id)
        {
            var client = ClientFactory.CreateClient();
            var url = "https://localhost:44304/delete/" + id.ToString();

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
    }
}
