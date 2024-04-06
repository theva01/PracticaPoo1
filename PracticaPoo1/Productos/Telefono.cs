using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{


    public class Telefono
    {
        private string marca;
        private string color;
        private string tipo;

        public Telefono()//ctor se encarga de inicializar los atributos
        {
            marca = "Apple";
            color = "azul";
            tipo = "touch";
            //este metodo no retorna datos
        }//solo se va a ejecutar una vez

        public void llamar()
        {
            System.Windows.Forms.MessageBox.Show("MI celular es un: "+ marca);
        }

        public void MandarMensaje()
        {

        }

    }
}
