using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiMultiTenancy.UseCase1.Controllers
{
    [RoutePrefix("api/v1/{tenantId}/ping")]
    public class PingController : ApiController
    {
        [HttpGet, Route("")]
        public IHttpActionResult Ping(string tenantId)
        {
            return Ok(tenantId);
        }
    }
}
