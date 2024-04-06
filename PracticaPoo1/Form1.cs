using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;

namespace PracticaPoo1
{
    public partial class Form1 : Form
    {
        Telefono Movistar = new Telefono();//Se creo el objeto
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Movistar.llamar();
            //Movistar.marca = "Samsung";
            Movistar.llamar();
        }
    }
}
