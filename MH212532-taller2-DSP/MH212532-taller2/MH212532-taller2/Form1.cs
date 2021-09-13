using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH212532_taller2
{
    public partial class Form1 : Form
    {
        //Creamos un array con 5 cuentas
        cuentaBancaria[] cuentas = new cuentaBancaria[5];
        //Creamos un array con 5 dui's
        string[] duis = { "10101010-1", "10101010-2", "10101010-3", "10101010-4", "10101010-5" }; 
        
        //Funcion para generar las cuentas, apartir del array
        public void generarCuentasBancarias()
        {
            string fechaActual = DateTime.Now.ToString("ddMMyyyy");
            int correlativo = 1000001;
            string numero = "";
            for (int i = 0; i < 5; i++)
            {
                numero = fechaActual + "-" + Convert.ToString(correlativo);
                cuentas[i] = new cuentaBancaria(numero, duis[i]);
                correlativo++;
            }
        }

        //Validamos las credenciales del login, para ver si coinciden con una cuenta activa
        public bool validarCuentaBancaria(string numeroCuentaLogIn, string duiCuentaLogIn)
        {
            bool estado = false;

            for (int i = 0; i < 5; i++)
            {
                if( cuentas[i].idCuenta == numeroCuentaLogIn && cuentas[i].duiCliente == duiCuentaLogIn)
                {
                    estado = true;
                }
            }

            return estado;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Generamos las cuentas al iniciar sesion
        private void Form1_Load(object sender, EventArgs e)
        {
            generarCuentasBancarias();
        }

        //Logeamos al usuario
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string numeroCuentaLogIn = txtNumeroCuenta.Text;
            string duiCuentaLogIn = txtDUI.Text;
            if (numeroCuentaLogIn != "" && duiCuentaLogIn != "")
            {
                if(validarCuentaBancaria(numeroCuentaLogIn, duiCuentaLogIn))
                {
                    dashboardCuenta showCuenta = new dashboardCuenta();
                    showCuenta.numeroActual = numeroCuentaLogIn;
                    showCuenta.duiActual = duiCuentaLogIn;
                    showCuenta.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No existe ninguna cuenta con esas credenciales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete los campos requeridos, por favor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cerramos la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
