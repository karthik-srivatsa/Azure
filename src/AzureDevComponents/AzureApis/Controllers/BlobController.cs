using AzureServiceContract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;

namespace AzureApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : ControllerBase
    {
        private IBlobService _blobService;

        public BlobController(IBlobService blobService)
        {
            _blobService = blobService;
        }
        
        // GET: api/Blobs
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // GET: api/Blobs/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Blobs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Blobs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}