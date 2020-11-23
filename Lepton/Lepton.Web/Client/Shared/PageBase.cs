using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lepton.Web.Client.Shared
{
    public class PageBase : ComponentBase
    {
        public bool IsLoaded { get; set; } = default;
    }
}
