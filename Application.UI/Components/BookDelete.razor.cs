using Application.UI.Services;
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
        protected QueryService QueryService { get; set; }
        public string DeletedId { get; set; }
    }
}
