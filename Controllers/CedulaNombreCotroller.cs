using Microsoft.AspNetCore.Mvc;
using reto2.net.bcevallos;
namespace reto2_net_bcevallos.Controllers;

[ApiController]
[Route("[controller]")]
public class CedulaNombreController : ControllerBase
{
    private readonly ICedulaNombreAppServices cedulaAppServices;

    public CedulaNombreController(ICedulaNombreAppServices cedulaAppServices)
    {
        this.cedulaAppServices = cedulaAppServices;
    }
    [HttpGet]
      public CedulaNombre GetByCedula(string cedula)
    {
        return cedulaAppServices.GetByCedula(cedula);
    }

}
