using Application.UI.Models;
using Application.UI.Services;
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
        protected QueryService QueryService { get; set; }
        public string FoundedId { get; set; }
        

    }
}
