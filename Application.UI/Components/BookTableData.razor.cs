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
    public partial class BookTableData
    {
        [Inject]
        protected QueryService QueryService { get; set; }


        protected override async Task OnInitializedAsync()
        { 
            await QueryService.GetAll();
        }

        public async Task UpdateAsync()
        {
            await OnInitializedAsync();
        }
    }
}


