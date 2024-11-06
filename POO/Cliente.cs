using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Cliente(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        private void MostrarInfo()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("El cliente es: ");
            msg.AppendLine($"Id: {ID}");
            msg.AppendLine($"Nombre: {Nombre}");

            Console.WriteLine(msg.ToString());
        }
    }
}
