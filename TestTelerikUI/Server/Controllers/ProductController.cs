using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestTelerikUI.Shared;
namespace TestTelerikUI.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            string json;
            using (StreamReader file = new StreamReader(@"..\Shared\sample-data\productList.json"))
            {
                json = file.ReadToEnd();
            }

            List<Product> listOfObjects = JsonConvert.DeserializeObject<List<Product>>(json);
            return listOfObjects;
        }
    }
}

