using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Authentication;

namespace Mvc.Client.Extensions 
{
    public static class HttpContextExtensions 
    {
        public static IEnumerable<AuthenticationDescription> GetExternalProviders(this HttpContext context) 
        {
            return 
            
                from description in context.Authentication.GetAuthenticationSchemes()
                    where !string.IsNullOrWhiteSpace(description.DisplayName)
                select description;
        }

        public static bool IsProviderSupported(this HttpContext context, string provider) 
        {
            return (
                
                from description in context.GetExternalProviders()
                    where string.Equals(description.AuthenticationScheme, provider, StringComparison.OrdinalIgnoreCase)
                select description
                
            ).Any();
        }
    }
}