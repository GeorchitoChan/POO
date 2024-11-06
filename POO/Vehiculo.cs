using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Vehiculo
    {
        public string Nombre { get; set; }
        public string Motor { get; set; }
        public string Potencia { get; set; }
        public string TipoDeFrenos { get; set; }
        public string SistemaDeCombustible { get; set; }

        public double PrecioRenta {  get; set; }
        public bool Disponible { get; set; }

        public Vehiculo(string nombre, string motor, string potencia, string sistemaDeCombustible, string tipoDeFrenos, double precioRenta, bool disponible)
        {
            Nombre = nombre;
            Motor = motor;
            Potencia = potencia;
            TipoDeFrenos = tipoDeFrenos;
            SistemaDeCombustible = sistemaDeCombustible;
            PrecioRenta = precioRenta;
            Disponible = disponible;
        }

        public virtual void MostrarInfo()
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

            Console.WriteLine(msg.ToString());
        }
    }
}
