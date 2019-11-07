using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
  public class Cliente
  {
    private int id;

    public int Id
    {
      get { return id; }
      set { id = value; }
    }

    private string nombre;

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    private string apellido;

    public string Apellido
    {
      get { return apellido; }
      set { apellido = value; }
    }

    private string dni;

    public string Dni
    {
      get { return dni; }
      set { dni = value; }
    }
    private DateTime? fechaNacimiento;

    public DateTime? FechaNacimiento
    {
      get { return fechaNacimiento; }
      set { fechaNacimiento = value; }
    }

    private List<Mascota> mascotas;

    public List<Mascota> Mascotas
    {
      get { return mascotas; }
      set { mascotas = value; }
    }


    public Cliente(int id, string nombre, string apellido, string dni, DateTime? fechaNacimiento)
    {
      this.id = id;
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
      this.fechaNacimiento = fechaNacimiento;
      this.mascotas = new List<Mascota>();
    }

    public static implicit operator string (Cliente cliente)
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(String.Format("{0} {1}", cliente.nombre, cliente.apellido));
      sb.AppendLine(String.Format("DNI: {0}", cliente.dni));
      if(cliente.fechaNacimiento != null)
      {
        sb.AppendLine(String.Format("FechaNacimiento: {0}",
          ((DateTime)cliente.fechaNacimiento).ToShortDateString()));
      }

      sb.AppendLine("Las mascotas son:");
      foreach (Mascota mascota in cliente.Mascotas)
      {
        sb.AppendLine(String.Format("{0} - {1}", mascota.Id, mascota.Nombre));
      }

      return sb.ToString();
    }

  }
}
