using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Auto : Vehiculo
    {
        public int NumeroDePuertas {  get; set; }
        public Auto(string nombre, string motor, string potencia, string sistemaDeCombustible, string tipoDeFrenos, double precioRenta, bool disponible, int numeroDePuertas) 
            : base(nombre, motor, potencia, sistemaDeCombustible, tipoDeFrenos, precioRenta, disponible)
        {
            NumeroDePuertas = numeroDePuertas;
        }
        public override void MostrarInfo()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("Las características del vehiculo son: ");
            msg.AppendLine($"Nombre: {Nombre}");
            msg.AppendLine($"Motor: {Motor}");
            msg.AppendLine($"Potencia: {Potencia}");
            msg.AppendLine($"Tipo de Frenos: {TipoDeFrenos}");
            msg.AppendLine($"Sistema de Combustible: {SistemaDeCombustible}");
            msg.AppendLine($"Precio de renta: {PrecioRenta}");
            msg.AppendLine($"Disponible: {(Disponible ? "Si" : "No")}");
            msg.AppendLine($"Número de Puertas: {NumeroDePuertas}");

            Console.WriteLine(msg.ToString());
        }
    }
}
