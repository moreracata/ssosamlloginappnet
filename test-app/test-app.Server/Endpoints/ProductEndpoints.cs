using test_app.Server.Models;

namespace test_app.Server.Endpoints
{
    public static class ProductEndpoints
    {
        public static void MapProductEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/products", (ProductService productService) =>
            {
                return Results.Ok(productService.GetAllProducts());
            });

            routes.MapGet("/products/{id}", (ProductService productService, int id) =>
            {
                var product = productService.GetProductById(id);
                return product != null ? Results.Ok(product) : Results.NotFound();
            });

            routes.MapPost("/products", (ProductService productService, Product product) =>
            {
                productService.AddProduct(product);
                return Results.Created($"/products/{product.Id}", product);
            });

            routes.MapDelete("/products/{id}", (ProductService productService, int id) =>
            {
                var success = productService.DeleteProduct(id);
                return success ? Results.NoContent() : Results.NotFound();
            });
        }
    }
}
