using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPoo1.Productos
{
    class Persona
    {
        private string nombre;
        private int id;
        private string pais;

        public string Nombre { get => nombre; set => nombre = value; }
        //public int Id { get => id; set => id = value; }
        //public string Pais { get => pais; set => pais = value; }

        public string Pais
        {
            get { return "Mi pais es: "+ pais; }
            set { pais = value; }
        }

        //forma generica de cear gets y sets
        public string Id { get; set; }
    }
}
