using ProyectoFinal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Entidades;
using System.Linq.Expressions;

namespace ProyectoFinal.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Usuarios.Add(usuarios) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(usuarios).State = System.Data.Entity.EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Usuarios.Find(id);
                db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios usuarios = new Usuarios();
            try
            {
                usuarios = db.Usuarios.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return usuarios;
        }


        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> persona)
        {
            List<Usuarios> people = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                people = db.Usuarios.Where(persona).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return people;
        }
    }
}
