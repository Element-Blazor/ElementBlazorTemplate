using Microsoft.AspNetCore.Authorization;

namespace Element.Admin
{
    public class ElAuthorizeView : BAuthorizeView
    {
        protected override IAuthorizeData[] GetAuthorizeData()
        {
            return base.GetAuthorizeData();
        }
    }
}

