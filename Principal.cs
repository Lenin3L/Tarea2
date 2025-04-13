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
    public partial class Form1: Form
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
            InicializarUsuarios();
            InicializarNuevo Usuriario();
            InicializarNuevoTrabajador();
            InicializarNuevaConstructora();
            InicializarConstructoraAntigua();

        }

        private void InicializarUsuarios()
        {
            usuarios.Add(new Usuario
            {
                Nombre = "Alejandro",
                Contraseña = "854848548",
                Rol = "Ingeniero",
                Edad = 30,
                Salario = 50000,
                Prestaciones = "Seguro, vacaciones",
            });

            usuarios.Add(new Usuario
            {
                Nombre = "Pedro",
                Contraseña = "456",
                Rol = "Maestro de Obra",
                Edad = 35,
                Salario = 40000,
                Prestaciones = "Seguro, vacaciones",
            });

            usuarios.Add(new Usuario
            {
                Nombre = "Alexander",
                Contraseña = "789",
                Rol = "Ayudante",
                Edad = 25,
                Salario = 30000,
                Prestaciones = "Seguro",
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.Nombre == usuario && u.Contraseña == contraseña);

            if (usuarioEncontrado != null)
            {
                switch (usuarioEncontrado.Rol)
                {
                    case "Ingeniero":
                        Form2 formIngeniero = new Form2(usuarioEncontrado);
                        formIngeniero.Show();
                        break;
                    case "Maestro de Obra":
                        Form3 formMaestroObra = new Form3(usuarioEncontrado);
                        formMaestroObra.Show();
                        break;
                    case "Ayudante":
                        Form4 formAyudante = new Form4(usuarioEncontrado);
                        formAyudante.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
