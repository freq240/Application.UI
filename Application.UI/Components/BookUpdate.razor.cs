using Application.UI.Models;
using Application.UI.Services;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Application.UI.Components
{
    public partial class BookUpdate
    {
        [Inject]
        protected QueryService QueryService{ get; set; }
        public string UpdatedId { get; set; }
        public string NewName { get; set; }
        public string NewPrice { get; set; }

        
        
    }
}
