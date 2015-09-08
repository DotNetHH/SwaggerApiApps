using Swashbuckle.Swagger;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Extensions
{
    public class AddDefaultResponse : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            var errorSchema = schemaRegistry.GetOrRegister(typeof(HttpError));

            operation.responses.Add("200", new Response
            {
                description = "Ok",
                schema = errorSchema
            });
        }
    }
}
