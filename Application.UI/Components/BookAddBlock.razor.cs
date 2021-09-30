using Application.UI.Models;
using Application.UI.Services;
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
        protected QueryService QueryService{ get; set; }

        public string NameOfNewBook { get; set; }
        public string PriceOfNewBook { get; set; }

    }
}
