
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
        
        logger.LogInformation(System.Convert.ToBase64String(plainTextBytes));

        var resultado = new CedulaNombre();
        resultado.Cedula=cedula;
        resultado.Nombre=System.Convert.ToBase64String(plainTextBytes);


        logger.LogInformation($"||METODO GET||Cedula:{System.Convert.ToBase64String(plainTextBytes)}||CODIGO 200");
        logger.LogTrace($"||METODO GET||Cedula:{System.Convert.ToBase64String(plainTextBytes)}||CODIGO 200");

        return resultado; 
    }
}