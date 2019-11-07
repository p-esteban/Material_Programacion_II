using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DAO.InsertarCliente("Mauricio", "Cerizza", "21321312", DateTime.Now);
                DAO.InsertarCliente("Fede", "Davila", "09876543", DateTime.MinValue);
                Console.WriteLine("Registro insertado correctamente");
                DAO.ModificarCliente(2, "Juan", "Perez", "21321312", DateTime.Now);
                Console.WriteLine("Registro modificado correctamente");

                List<Cliente> clientes = DAO.LeerClientes();
                foreach (Cliente cliente in clientes)
                {
                  Console.WriteLine(cliente);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
