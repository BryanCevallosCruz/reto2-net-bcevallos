
using Microsoft.Extensions.Logging;

namespace reto2.net.bcevallos;

public class CedulaNombreAppServices : ICedulaNombreAppServices
{
    private readonly ILogger<CedulaNombreAppServices> logger;

    public CedulaNombreAppServices(ILogger<CedulaNombreAppServices> logger)
    {
        this.logger = logger;
    }
    public CedulaNombre GetByCedula(string cedula)
    {
        var cedulaNombre = new Dictionary<string, string>()
        {
            {"0504045678", "Raul Velasco"}, 
            {"1234567890", "Joaquin Romero"}
        } ;

        logger.LogInformation("Obtener por cedula");

        var valor = cedulaNombre[cedula];
        // 
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(valor);
        System.Convert.ToBase64String(plainTextBytes);
        //logger.LogInformation(plainTextBytes);

        var resultado = new CedulaNombre();
        resultado.Cedula=cedula;
        resultado.Nombre=valor;

        logger.LogTrace("Hola");

        return resultado; 
    }
}