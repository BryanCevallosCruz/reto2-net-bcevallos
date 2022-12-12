
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
        };

        logger.LogInformation("Obtener por cedula");

        var valor = cedulaNombre[cedula];
        logger.LogInformation(valor);
        // 
        if (valor == null)
        {
           var msg = $"No existe la cedula {cedula}";
            logger.LogError(msg);

            throw new ArgumentException(msg);
        }
        else
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(valor);

            var resultado = new CedulaNombre();
            resultado.Cedula = cedula;
            resultado.Nombre = System.Convert.ToBase64String(plainTextBytes);


            logger.LogInformation($"||METODO GET||Cedula:{System.Convert.ToBase64String(plainTextBytes)}||CODIGO 200");
            logger.LogTrace($"||METODO GET||Cedula:{System.Convert.ToBase64String(plainTextBytes)}||CODIGO 200");

            return resultado;
        }
    }
}