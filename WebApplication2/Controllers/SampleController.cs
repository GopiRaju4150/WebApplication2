using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        
        [HttpGet]
        [Route("GetStringData")]//Chield Routes
        public string ListOfData()
        {
            var Results = "it department";
            return Results;
        }
        
        [HttpPost]
        [Route("insertData")]//Chield Routes
        public int Insert(int a, int b)
        {
            return a + b;
        }
       
        [HttpPut]
        [Route("updateData")]//Chield Routes
        public int Update(int a, int b)
        {
            return a - b;
        }
       
        [HttpDelete]
        [Route("deleteData")]//Chield Routes
        public int Delete(int a, int b)
        {
            return a * b;
        }
    }
}
