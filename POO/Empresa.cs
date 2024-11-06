using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO
{
    public class Empresa
    {
        public List<Vehiculo> Vehiculos { get; set; }
        public List<Alquiler> Alquileres { get; set; }
        public List<Cliente> Clientes { get; set; }

        public Empresa()
        {
            Vehiculos = new List<Vehiculo>();
            Alquileres = new List<Alquiler>();
            Clientes = new List<Cliente>();
        }

        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }
        public void RegistrarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void RegistrarAlquiler(int idCliente, string nombreVehiculo)
        {
            Cliente ?cliente = Clientes.Find(item => item.ID == idCliente);
            Vehiculo ?vehiculo = Vehiculos.Find(vehiculo => vehiculo.Nombre == nombreVehiculo);

            if (cliente == null)
            {
                Console.WriteLine("No existe el cliente para poder registrar un alquiler.");
                return;
            }

            if (vehiculo == null)
            {
                Console.WriteLine("Vehículo no encontrado.");
                return;
            }

            if (vehiculo.Disponible)
            {
                Alquiler alquiler = new Alquiler(vehiculo, cliente, DateTime.Now, DateTime.Now);
                Alquileres.Add(alquiler);

                Vehiculos.Find(item => item == vehiculo).Disponible = false;               
            }
            else
            {
                Console.WriteLine("El Vehículo no esta disponible.");
                return;
            }

            
        }
        public void ImprimirAlquileres()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("Listado de alquileres: ");
            foreach (Alquiler item in Alquileres)
            {               
                msg.AppendLine($"Cliente: {item.Cliente.Nombre}");
                msg.AppendLine($"Vehiculo: {item.VehiculoAlquilado.Nombre}");
                msg.AppendLine($"Fecha Inicio: {(item.FechaInicio)}");
                msg.AppendLine($"Fecha Fin: {item.FechaFin}");
                msg.AppendLine(Environment.NewLine);
            }
            Console.WriteLine(msg.ToString());
        }
        public void ImprimirVehiculos()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("Listado de vehiculos: ");
            foreach (Vehiculo item in Vehiculos)
            {
                msg.AppendLine($"Nombre: {item.Nombre}");
                msg.AppendLine($"Motor: {item.Motor}");
                msg.AppendLine($"Potencia: {item.Potencia}");
                msg.AppendLine($"Tipo de Frenos: {item.TipoDeFrenos}");
                msg.AppendLine($"Sistema de Combustible: {item.SistemaDeCombustible}");
                msg.AppendLine($"Precio de renta: {item.PrecioRenta}");
                msg.AppendLine($"Disponible: {(item.Disponible ? "Si" : "No")}");
                msg.AppendLine(Environment.NewLine);
            }
            Console.WriteLine(msg.ToString());
        }
    }
}
