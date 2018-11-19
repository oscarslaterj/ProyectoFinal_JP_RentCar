using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Entidades;
using ProyectoFinal.DAL;
using System.Linq.Expressions;

namespace ProyectoFinal.BLL
{
    public class ClientesBLL
    {

        public static bool Guardar(Clientes cliente)
    {
        bool paso = false;
        Contexto contexto = new Contexto();

        try
        {
            if (contexto.Clientes.Add(cliente) != null)
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


    public static bool Modificar(Clientes cliente)
    {
        bool paso = false;
        Contexto db = new Contexto();

        try
        {
            db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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
            var eliminar = db.Clientes.Find(id);
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


    public static Clientes Buscar(int id)
    {
        Contexto db = new Contexto();
        Clientes cliente = new Clientes();
        try
        {
            cliente = db.Clientes.Find(id);
            db.Dispose();
        }
        catch (Exception)
        {
            throw;
        }
        return cliente;
    }


    public static List<Clientes> GetList(Expression<Func<Clientes, bool>> persona)
    {
        List<Clientes> people = new List<Clientes>();
        Contexto db = new Contexto();
        try
        {
            people = db.Clientes.Where(persona).ToList();
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
