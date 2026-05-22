
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.ClientRenderWithSeo.Client.Demo.MessageBox
{
    public class ConfirmMessageBoxBase : ComponentBase
    {
        [Inject]
        MessageService MessageService { get; set; }
        [Inject]
        Component.MessageBox MessageBox { get; set; }
        public async Task ShowMessageAsync()
        {
            var result = await MessageBox.ConfirmAsync("≤‚ ‘œ˚œ¢");
            MessageService.Show(result.ToString());
        }
    }
}
