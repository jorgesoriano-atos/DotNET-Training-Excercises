using FirstWebAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {

        //GET TO https://localhost:44332/api/Example/12
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Logic to return something based on id.
            return id.ToString();
        }


        //POST TO https://localhost:44332/api/Example
        [HttpPost]
        public string Post(SampleDTO sample)
        {
            //Tipically return the created object DTO
            return $"1:{sample.FirstParam}, 2:{sample.SecondParam}.";
        }
    }
}
