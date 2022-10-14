using Microsoft.AspNetCore.Mvc;
using WebApicursodevops.Controllers.Modelos;

namespace WebApicursodevops.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Clientecontroller : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarClient()

        {
            List<Cliente> clientes = new List<Cliente>
        {

                new Cliente


             {
                id = "1",
                nombre = "2",
                edad = "santiago@gmail.com",
                correo = "Santiago Diaz"

                },

                 new Cliente

                {
                id = "2",
                nombre = "Oriana",
                edad = "oriana@gmail.com",
                correo = "Santiago Diaz"

                }

                  new Cliente

                {
                id = "3",
                nombre = "Miguel",
                edad = "miguel@gmail.com",
                correo = "MIguel Diaz"

                }

            };

            return clientes;
        }

    }
  
}
