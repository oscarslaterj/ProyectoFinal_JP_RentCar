using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
   public class Vehiculos
    {
        [Key]

        public int VehiculoID { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioRenta { get; set; }
        public DateTime FechaRegistro { get; set; }


        public Vehiculos()
        {
            VehiculoID = 0;
            Placa = string.Empty;
            Tipo = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Anio = string.Empty;
            Descripcion = string.Empty;
            PrecioRenta = 0;
            FechaRegistro = DateTime.Now;
        }


    }
}
