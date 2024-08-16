using Saml;
using test_app.Server.Models;

namespace test_app.Server.Endpoints
{
    public static class AuthEndpoints
    {
        public static void MapAuthEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/login", (SamlSettings samlSettings) =>
            {
                var samlEndpoint = "http://saml-provider-that-we-use.com/login/";

                var request = new AuthRequest(
                    "http://www.myapp.com", //TODO: put your app's "entity ID" here
                    "http://www.myapp.com/SamlConsume" //TODO: put Assertion Consumer URL (where the provider should redirect users after authenticating)
                );

                //now send the user to the SAML provider
              

                return Results.Ok("Hola");
            });

            routes.MapGet("/assertion", (ProductService productService) =>
            {
                return Results.Ok(productService.GetAllProducts());
            });

            routes.MapGet("/metadata", (ProductService productService) =>
            {
                return Results.Ok(productService.GetAllProducts());
            });

            routes.MapGet("/authRequest", (ProductService productService) =>
            {
                return Results.Ok(productService.GetAllProducts());
            });



        }
    }
}
