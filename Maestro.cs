﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azul
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Usuario usuario) : this()
        {
            label9.Text = usuario.Nombre;
            label8.Text = usuario.Edad.ToString();
            label7.Text = usuario.Rol;
            label5.Text = usuario.Salario.ToString();
            label6.Text = usuario.Prestaciones;

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
