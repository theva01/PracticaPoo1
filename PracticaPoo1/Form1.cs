using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaPoo1.Productos;
using Productos;

namespace PracticaPoo1
{
    public partial class Form1 : Form
    {
        Persona p = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            p.Pais = "Costa Rica";
            p.Id = "106444332";
            MessageBox.Show(p.Pais +" con ID: "+ p.Id);
        }
    }
}
