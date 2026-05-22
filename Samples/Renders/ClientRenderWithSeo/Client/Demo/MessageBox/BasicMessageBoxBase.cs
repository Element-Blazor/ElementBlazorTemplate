
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Element;
using System.Threading.Tasks;

namespace Element.ClientRenderWithSeo.Client.Demo.MessageBox
{
    public class BasicMessageBoxBase : ComponentBase
    {
        [Inject]
        MessageService MessageService { get; set; }
        [Inject]
        Component.MessageBox MessageBox { get; set; }
        public async Task ShowMessageAsync()
        {
            var result = await MessageBox.AlertAsync("≤‚ ‘œ˚œ¢");
            MessageService.Show(result.ToString());
        }
    }
}
