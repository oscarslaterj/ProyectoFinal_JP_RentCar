using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class RentasDetalle
    {
        [Key]
        public int IdDetalle { get; set; }
        public int IdVehiculo { get; set; }
        public int IdRenta { get; set; }
        public String Año { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public decimal Precio { get; set; }

        public RentasDetalle()
        {
            IdDetalle = 0;
            IdVehiculo = 0;
            IdRenta = 0;
            Año = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Precio = 0;
        }

       public RentasDetalle(int idDetalle, int idVehiculo, int idRenta, string año, string marca, string modelo, decimal precio)
        {
            IdDetalle = idDetalle;
            IdVehiculo = idVehiculo;
            IdRenta = idRenta;
            Año = año;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }
    }
}
