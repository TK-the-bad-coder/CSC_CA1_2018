using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CSCAssignment2018.Models;
using CSCAssignment2018.Filters;

namespace CSCAssignment2018.Controllers
{
    public class ProductsV2Controller : ApiController
    {
        static readonly IProductRepository repository = new ProductRepository();
        [HttpGet]
        [Route("api/v2/products")]
        public IEnumerable<Product> GetAllProducts() //get all
        {
            return repository.GetAll();

        }
        //GET , POST, PUT , DELETE
        [HttpGet]
        [Route("api/v2/products/{id:int}", Name = "getProductById")]
        public HttpResponseMessage GetProduct(int id) //get by id, changed to HttpResponseMessage to return message when error encounter.
        {
            Product item = repository.Get(id);
            //if (item == null)
            //{
            //    throw new HttpResponseException(HttpStatusCode.NotFound); //throws exception 404 if the id is invalid 
            //}
            //return item;
            HttpResponseMessage response = null;
            if (item == null)
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound, "Invalid id. Invalid get request.");
                // throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                response = Request.CreateResponse<Product>(HttpStatusCode.OK, item);
            }
            return response;

        }
        //returns products based on category
        [HttpGet]
        [Route("api/v2/products")]
        //http://localhost:9000/api/v2/products/category?category=3
        public IEnumerable<Product> GetProductsByCategory(string category) //get by category
        {
            return repository.GetAll().Where(
                p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));

        }
        //Post
        [ValidateModel]
        [HttpPost]
        
        [Route("api/v2/products")]
        public HttpResponseMessage PostProduct(Product item) //create product
        {
            
            if (ModelState.IsValid)
            {
                item = repository.Add(item);
                var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);
                string uri = Url.Link("getProductById", new { id = item.Id });
                response.Headers.Location = new Uri(uri);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        //Put
        [ValidateModel]
        [HttpPut]
        [Route("api/v2/products/{id:int}")]
        public HttpResponseMessage PutProduct(int id, Product product)
        {
            product.Id = id;
            HttpResponseMessage response = null;
            if (!repository.Update(product))
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound, "Invalid id. Invalid update request.");
               // throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                response = Request.CreateResponse<Product>(HttpStatusCode.OK, product);
            }
            return response;
        }

        //delete
        [HttpDelete]
        [Route("api/v2/products/{id:int}")]
        public HttpResponseMessage DeleteProduct(int id)
        {
            Product item = repository.Get(id);
            HttpResponseMessage response = null;
            if (item == null)
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound, item.Id + " is not found. Invalid delete request.");
            }
            else
            {
                repository.Remove(id);

                response = Request.CreateResponse<Product>(HttpStatusCode.Accepted, item);
            }
            return response;
        }



    }
}
