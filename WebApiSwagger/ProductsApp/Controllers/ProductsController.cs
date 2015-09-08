using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();

        // GET: api/Products
        /// <summary>
        /// Get all Products
        /// </summary>
        /// <remarks>Get all Products</remarks>
        /// <response code="200">Ok</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>IEnumerable&lt;Product&gt;</returns>
        [HttpGet]
        [Route("api/Products")]
        [ResponseType(typeof(IEnumerable<Product>))]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            return Ok(products.AsEnumerable());
        }

        // GET: api/Product/12
        /// <summary>
        /// Get Product by id
        /// </summary>
        /// <param name="id">int ProductId</param>
        /// <remarks>Get a Product</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Product</returns>
        [HttpGet]
        [Route("api/Product/{id}")]
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // PUT: api/Product
        /// <summary>
        /// add a Product
        /// </summary>
        /// <param name="product">Product productToBeAdded</param>
        /// <remarks>Add a Product</remarks>
        /// <response code="200">Ok</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPut]
        [Route("api/Product")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> AddProduct(Product product)
        {
            products.Add(product);
            return Ok();
        }

        // PATCH: api/Product
        /// <summary>
        /// update a Product
        /// </summary>
        /// <param name="product">Product updatedProduct</param>
        /// <remarks>Update a Product</remarks>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Product</returns>
        [HttpPatch]
        [Route("api/Product")]
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> UpdateProduct(Product product)
        {
            if (product == null)
                return BadRequest();

            foreach(var p in products)
            {
                if(p.Id == product.Id)
                {
                    p.Category = product.Category;
                    p.Name = product.Name;
                    p.Price = product.Price;

                    return Ok(p);
                }
            }

            return NotFound();
        }

        // DELETE: api/Product/12
        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="id">int ProductId</param>
        /// <remarks>Delete a Product</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/Product/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteProduct(int id)
        {
            var product = products?.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            products.Remove(product);
            return Ok();
        }
    }
}
