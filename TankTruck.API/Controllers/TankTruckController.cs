using Microsoft.AspNetCore.Mvc;
using TankTruck.App;

namespace TankTruck.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TankTruckController : ControllerBase
    {

        [HttpGet("tankvol/{h}/{d}/{vt}")]
        public ActionResult GetVolumeOfTank(int h, int d, int vt)
        {
            IVolumeOfTank volume = new VolumeOfTank();


            var result = volume.TankVol(h, d, vt);

            return Ok(result);

        }
    }
}
