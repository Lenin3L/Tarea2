using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azul
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Usuario usuario) : this()
        {
            label9.Text = usuario.Nombre;
            label8.Text = usuario.Edad.ToString();
            label7.Text = usuario.Rol;
            label11.Text = usuario.Salario.ToString();
            label6.Text = usuario.Prestaciones;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
