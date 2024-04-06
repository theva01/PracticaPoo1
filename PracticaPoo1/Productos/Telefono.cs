using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Productos
{


    public class Telefono
    {
        private string marca;
        private string color;
        private string tipo;

        public Telefono()//ctor se encarga de inicializar los atributos
        {
            marca = "Nokia";
            color = "azul";
            tipo = "touch";
            //este metodo no retorna datos
        }//solo se va a ejecutar una vez

        public Telefono(string m)
        {
            marca = m;
            color = "azul";
            tipo = "touch";
        }

        public Telefono(string m, string c, string t)
        {
            marca = m;
            color = c;
            tipo = t;
        }

        public void llamar()
        {
            System.Windows.Forms.MessageBox.Show("Mi celular es un: "+ marca + " es color: "+color+" es de tipo: "+tipo);
        }

        public void MandarMensaje()
        {

        }

    }
}
