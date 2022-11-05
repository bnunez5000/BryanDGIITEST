using DGII.Modelos;

namespace DGII.BD
{

    public class Datos
    {
        public static List<Comprobantes> comprobtes_fiscales = null;
        public static List<Contribuyentes> contriyentes = null;

        public Datos()
        {
            /* DATA PARA MOSTRAR EN EL WEB SERVICES */
            comprobtes_fiscales = new List<Comprobantes>
            {
                new Comprobantes{
                    rncCedula= "98754321012",
                    eNCF= "E310000000001",
                    monto= "200.00",
                    itbis18= "36.00"
                },
                new Comprobantes{
                   rncCedula= "98754321012",
                   eNCF = "E310000000002",
                   monto= "1000.00",
                   itbis18= "180.00"
                }
            };


            /* Datos de contribueytes*/
            /* DATA PARA MOSTRAR EN EL WEB SERVICES */
            contriyentes = new List<Contribuyentes>
            {
                new Contribuyentes{
                    rncCedula = "98754321012",
                    nombre = "JUAN PEREZ",
                    tipo = "PERSONA FISICA",
                    estatus = "activo"
                },
                new Contribuyentes{
                    rncCedula = "98754321012",
                    nombre = "JUAN PEREZ",
                    tipo = "PERSONA FISICA",
                    estatus = "activo"
                }
            };

        }
    }
}