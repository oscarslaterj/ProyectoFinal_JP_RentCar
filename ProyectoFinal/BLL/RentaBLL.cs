﻿using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class RentaBLL
    {
        public static bool Guardar(Renta renta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Renta.Add(renta) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Renta renta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = db.Renta.Find(renta.RentaID);
                db.Entry(renta).State = EntityState.Modified;
                foreach (var item in Anterior.Detalle)
                {
                    /*if (!renta.Vehiculos.Exists(d => d.VehiculoID== item.VehiculoID))
                        db.Entry(item).State = EntityState.Deleted;*/
                    if (item.IdVehiculo == 0)
                        guardarDetalle(item);
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                        paso = db.SaveChanges() > 0;
                    }
                }
                
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }

            return paso;
        }

        private static bool guardarDetalle(RentasDetalle Detalle)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.Rentadetalle.Add(Detalle)!=null)
                {
                    db.SaveChanges();
                    paso = true;
                }
            }catch(Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;

        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Eliminar = db.Renta.Find(Id);
                db.Entry(Eliminar).State = System.Data.Entity.EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Renta Buscar(int Id)
        {
            Contexto db = new Contexto();
            Renta renta = new Renta();
            try
            {
                renta = db.Renta.Find(Id);
               renta.Detalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return renta;
        }


        public static List<Renta> GetList(Expression<Func<Renta, bool>> renta)
        {
            List<Renta> Lista = new List<Renta>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Renta.Where(renta).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}
