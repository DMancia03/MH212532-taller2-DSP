using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH212532_taller2
{
    //CLASE: Cuenta Bancaria (cuentaBancaria)
    //ATRIBUTOS
    //Número de cuenta (idCuenta)
    //El n número de la cuenta debe ajustarse al siguiente
    //formato DDMMYYYY-XXXXXX donde XXXXXX es un número correlativo
    //que comienza en 1000001.
    //DUI (duiCliente)
    //Saldo actual (saldoActual)
    //Interés Anual (interesAnual)
    //Interés Diario (interesDiario)
    //Estado (estadoActivo)
    //MÉTODOS
    //__cuentaBancaria(): constructor clase

    //actualizarSaldo(): actualizará el saldo de la cuenta
    //aplicándole el interés diario. (interés anual dividido entre
    //365 aplicado al saldo actual).

    //ingresar(double): permitirá ingresar una cantidad ($) en la
    //cuenta.

    //retirar(double): permitirá sacar una cantidad ($) de la cuenta
    //(si hay saldo).

    //Mostrar(): permita mostrar todos los datos de la cuenta.

    //Cerrar(): permita al cliente cerrar la cuenta bancaria.
    class cuentaBancaria
    {
        //ATRIBUTOS
        public string idCuenta { get; set; }
        public string duiCliente { get; set; }
        public double saldoActual { get; set; }
        public double interesAnual { get; set; }
        private double interesDiario { get; set; }
        public bool estadoActivo { get; set; } //Sirve para ver si la cuenta esta "cerrada" o "abierta"

        //MÉTODOS
        //Constructor
        public cuentaBancaria(string numeroCuenta, string dui)
        {
            this.idCuenta = numeroCuenta;
            this.duiCliente = dui;
            this.saldoActual = 0;
            this.estadoActivo = true;
        }

        //Asignar el interes anual apartir del saldo
        public void asignarInteresAnual()
        {
            double saldo = this.saldoActual;

            if (saldo <= 500)
            {
                this.interesAnual = 0.10;
            }
            else if (saldo > 500 && saldo <= 1000)
            {
                this.interesAnual = 0.15;
            }
            else if (saldo > 1000 && saldo <= 10000)
            {
                this.interesAnual = 0.20;
            }
            else
            {
                this.interesAnual = 0.223;
            }

            this.asignarInteresDiario();
        }

        //Asignar el interes diario a partir del interes anual
        private void asignarInteresDiario()
        {
            this.interesDiario = this.interesAnual / 365;
        }

        //Actualizar saldo
        public void actualizarSaldo()
        {
            double porcentajeSaldo = this.saldoActual * this.interesDiario;
            this.saldoActual = this.saldoActual - porcentajeSaldo;
        }

        //Abonar
        public void ingresar(double abono)
        {
            this.saldoActual = this.saldoActual + abono;

            asignarInteresAnual();
        }

        //Retirar
        public void retirar(double retiro)
        {
            this.saldoActual = this.saldoActual -retiro;

            asignarInteresAnual();
        }

        //Verificar si tiene fondos
        public bool fundosSuficientes()
        {
            bool estado = true;

            if(this.saldoActual > 0)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            return estado;
        }

        //Abrir la cuenta
        public void abrirCuenta()
        {
            this.estadoActivo = true;
        }

        //Cerrar cuenta
        public void cerrarCuenta()
        {
            this.estadoActivo = false;
        }

        //Devolver en una cadena todos los datos
        public string mostrar()
        {
            string cadenaDatos = "Número cuenta: " + this.idCuenta + " | Dui: " + this.duiCliente + " | Saldo Actual: " + this.saldoActual + " | Intéres Anual: " + this.interesAnual + " | Intéres diario: " + this.interesDiario;

            return cadenaDatos;
        }
    }
}
