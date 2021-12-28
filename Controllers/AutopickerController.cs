using carrr.Domain;
using carrr.Repository;
using Microsoft.AspNetCore.Mvc;

namespace carrr.Controllers
{
    [ApiController]
    [Route("/autopicker")]
    public class AutopickerController : ControllerBase
    {
        [HttpPut]
        public Autopicker Create(Autopicker autopicker)
        {
            Storage.AutopickerStorage.Create(autopicker);
            return autopicker;
        }

        [HttpGet]
        public Autopicker Read(int autopickerId)
        {
            return Storage.AutopickerStorage.Read(autopickerId);
        }

        [HttpPost]
        public Autopicker Update(int autopickerId, Autopicker newAutopicker)
        {
            return Storage.AutopickerStorage.Update(autopickerId, newAutopicker);
        }

        [HttpDelete]
        public bool Delete(int autopickerId)
        {
            return Storage.AutopickerStorage.Delete(autopickerId); ;
        }
    }
}