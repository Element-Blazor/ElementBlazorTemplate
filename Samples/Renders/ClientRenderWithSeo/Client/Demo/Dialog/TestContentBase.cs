
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Element;
using System.Threading.Tasks;

namespace Element.ClientRenderWithSeo.Client.Demo.Dialog
{
    public class TestContentBase:ElementDialogBase
    {
        [Parameter]
        public string Name { get; set; }
    }
}
