using carrr.Domain;
using carrr.Repository;
using Microsoft.AspNetCore.Mvc;

namespace carrr.Controllers
{
    [ApiController]
    [Route("/request")]
    public class RequestController : ControllerBase
    {
        [HttpPut]
        public Request Create(Request request)
        {
            Storage.RequestStorage.Create(request);
            return request;
        }

        [HttpGet]
        public Request Read(int requestId)
        {
            return Storage.RequestStorage.Read(requestId);
        }

        [HttpPost]
        public Request Update(int requestId, Request newRequest)
        {
            return Storage.RequestStorage.Update(requestId, newRequest);
        }

        [HttpDelete]
        public bool Delete(int requestId)
        {
            return Storage.RequestStorage.Delete(requestId); ;
        }
    }
}