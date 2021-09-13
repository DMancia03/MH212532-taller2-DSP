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
    public partial class dashboardCuenta : Form
    {
        //Ponemos estas variables, que reciben su valor desde el anterior formulario
        public string numeroActual;
        public string duiActual;
        cuentaBancaria cuentaActiva;

        //Colocamos el sueldo en un textbox
        public void setSueldoInterfaz()
        {
            txtSueldoActual.Text = Convert.ToString(cuentaActiva.saldoActual);
            if (!(cuentaActiva.fundosSuficientes()))
            {
                MessageBox.Show("No cuenta con fondos, realice abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public dashboardCuenta()
        {
            InitializeComponent();
        }

        //Cargamos la cuenta con los datos pasados de la cuenta que logro logearse
        private void dashboardCuenta_Load(object sender, EventArgs e)
        {
            cuentaActiva = new cuentaBancaria(numeroActual, duiActual);
            setSueldoInterfaz();
        }

        //Configurar el cierre de sesion
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            cuentaActiva.actualizarSaldo(); //Se actualiza el saldo
            //Pues se considera que al salir de la sesion, esta finalizando
            //un dia
            Form1 logIn = new Form1();
            logIn.Show();
            this.Hide();
        }

        //Cerramos la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Se abona a la cuenta
        private void btnAbonar_Click(object sender, EventArgs e)
        {
            int num;
            double abono;
            string cantidad = "";
            do
            {
                cantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la cantidad:", "");
            } while (!(Int32.TryParse(cantidad, out num)));
            abono = Convert.ToDouble(cantidad);
            
            cuentaActiva.ingresar(abono);

            lstTransacciones.Items.Add("Abonos de $" + cantidad);

            setSueldoInterfaz();
        }

        //Se retire a la cuenta
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            int num;
            string cantidad = "";
            double retiro;
            do
            {
                cantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la cantidad:", "");
            } while (!(Int32.TryParse(cantidad, out num)));

            retiro = Convert.ToDouble(cantidad);

            if (cuentaActiva.saldoActual > retiro)
            {
                cuentaActiva.retirar(retiro);

                lstTransacciones.Items.Add("Retiro de $" + cantidad);

                setSueldoInterfaz();
            }
            else
            {
                MessageBox.Show("No cuenta con fondos suficientes para retirar essa cantidad.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Se cierra la cuenta
        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            cuentaActiva.cerrarCuenta();
            lstTransacciones.Items.Add("Se ha cerrado la cuenta.");

            btnAbonar.Enabled = false;
            btnRetirar.Enabled = false;
            btnCerrar.Enabled = false;
        }

        //Se muestra los datos
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuentaActiva.mostrar(), "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
