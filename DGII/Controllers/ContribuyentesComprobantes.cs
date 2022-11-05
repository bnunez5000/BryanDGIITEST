using DGII.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using DGII.BD;

namespace DGII.Controllers
{
    [ApiController]
    [Route("Listar")]

    public class ContribuyentesComprobantes : ControllerBase
    {
        [HttpGet]
        [Route("ListarContribuyentes")]

        public dynamic Listar_contriyentes()
        {
            Datos bd = new Datos();
            return Datos.contriyentes;
        }

        [HttpGet]
        [Route("ListarComprobantesFiscales")]

        public dynamic Listar_Comprobantes_Fiscales()
        {
            /* Inicializando datos */
            Datos bd = new Datos();
            return Datos.comprobtes_fiscales;
        }

        [HttpGet]
        [Route("ListarCientePorID")]

        public dynamic ListarPorID(string RNCCedula)
        {
            /* Inicializando datos */
            Datos bd = new Datos();
            return Datos.comprobtes_fiscales;
        }
    }
}