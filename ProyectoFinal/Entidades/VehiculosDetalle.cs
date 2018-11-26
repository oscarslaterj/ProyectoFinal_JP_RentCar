﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
   public class VehiculosDetalle
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


        public VehiculosDetalle()
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

        public VehiculosDetalle(int vehiculoID, string placa, string tipo, string marca, string modelo, string anio, string descripcion, decimal precioRenta, DateTime fechaRegistro)
        {
            VehiculoID = vehiculoID;
            Placa = placa;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Descripcion = descripcion;
            PrecioRenta = precioRenta;
            FechaRegistro = fechaRegistro;
        }

        public override string ToString()
        {
            return this.Descripcion;
        }

    }
}
