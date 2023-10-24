using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        static List<Event> events;
        static int id=0;

        // GET: api/<EventController>
        [HttpGet]
        public List<Event> Get()
        {

            return eve ;
        }

        //// GET api/<EventController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] string title,DateTime start,DateTime end)
        {
            id++;
            events.Add(new Event(id,title,start,end));

        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event eve)
        {
            //events.Remove(events.Where(e => e.id = id));
            events.Add(eve);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            for(int i=0;i<events.Count;i++)
            {

               if(events[i].id==id)
                    events



            }

        }
    }
}
