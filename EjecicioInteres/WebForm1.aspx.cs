using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjecicioInteres
{

    

    public partial class WebForm1 : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long monto_a_solicitar = 0; // valor entero positivo, máximo 3000 millones
            sbyte numero_de_cuotas = 0; //valor entero positivo, máximo 72
            float valor_cuota_mensual = 0; //valor numérico con aproximación a 2 decimales
            float tasa_de_interes = 0;
            if (monto_a_solicitar <= 500000)
            {
                tasa_de_interes = 2.4;
            }
            else if (monto_a_solicitar > 500000 && monto_a_solicitar < 1500000)
            {
                tasa_de_interes = 2.1;
            }
            else if (monto_a_solicitar > 150000 && monto_a_solicitar < 5000000)
            {
                tasa_de_interes = 1.8;
            }
            else
            {
                tasa_de_interes = 1.4;
            }

            //Valor Cuota = (Monto * (1 + (Tasa de Interés/100)*número de cuotas)) /(número de cuotas) 
            valor_cuota_mensual = (monto_a_solicitar * (1 + (tasa_de_interes / 100) * numero_de_cuotas)) / numero_de_cuotas;
        }
    }
}