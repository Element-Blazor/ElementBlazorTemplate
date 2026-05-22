
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.ClientRenderWithSeo.Client.Demo.Form
{
    public class BasicFormBase : ComponentBase
    {
        internal LabelAlign formAlign;
        [Inject]
        Component.MessageBox MessageBox { get; set; }

        protected ElForm demoForm;
        protected void Submit()
        {
            if (!demoForm.IsValid())
            {
                return;
            }

            var activity = demoForm.GetValue<Activity>();
            _ = MessageBox.AlertAsync(activity.ToString());
        }

        

        protected void Reset()
        {
            demoForm.Reset();
        }
    }
}
