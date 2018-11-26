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


        public RentasDetalle()
        {
            IdDetalle = 0;
            IdVehiculo = 0;
            IdRenta = 0;
        }

        public RentasDetalle(int idDetalle, int idVehiculo, int idRenta)
        {
            IdDetalle = idDetalle;
            IdVehiculo = idVehiculo;
            IdRenta = idRenta;
        }
    }
}
