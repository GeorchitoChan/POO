using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO
{
    public class Alquiler
    {
        public Vehiculo VehiculoAlquilado { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Alquiler(Vehiculo vehiculoAlquilado, Cliente cliente, DateTime fechaInicio, DateTime fechaFin)
        {
            VehiculoAlquilado = vehiculoAlquilado;
            Cliente = cliente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        private void MostrarInfo()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("Detalle del alquiler: ");
            msg.AppendLine($"=== Datos del cliente ===");
            msg.AppendLine($"Id Cliente: {Cliente.ID}");
            msg.AppendLine($"Nombre del Cliente: {Cliente.Nombre}");
            msg.AppendLine($"=== Datos del Vehículo ===");
            msg.AppendLine($"Motor: {VehiculoAlquilado.Motor}");
            msg.AppendLine($"Potencia: {VehiculoAlquilado.Potencia}");
            msg.AppendLine($"Tipo de Frenos: {VehiculoAlquilado.TipoDeFrenos}");
            msg.AppendLine($"Sistema de Combustible: {VehiculoAlquilado.SistemaDeCombustible}");
            msg.AppendLine($"Precio de renta: {VehiculoAlquilado.PrecioRenta}");
            msg.AppendLine($"Disponible: {(VehiculoAlquilado.Disponible ? "Si" : "No")}");
            msg.AppendLine($"=== Periodo de alquiler ===");
            msg.AppendLine($"Fecha inicio: {FechaInicio}");
            msg.AppendLine($"Fecha fin: {FechaFin}");

            Console.WriteLine(msg.ToString());
        }


    }
}
