using Microsoft.AspNetCore.Mvc;

namespace Online.Shopping.Store.Attributes
{
    internal class OssApiRoute : RouteAttribute
    {
        public OssApiRoute(string template) : base($"/api/v1/{template}")
        {

        }
    }
}
