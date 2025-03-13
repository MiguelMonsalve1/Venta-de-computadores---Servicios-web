using ServicioREST.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases
{
    public class Computadores
    {
        private VentaComputadoresEntities dbsuper = new VentaComputadoresEntities();

        public Computador computador { get; set; }

        public string Ingresar()
        {
            try
            {
                dbsuper.Computador.Add(computador);
                dbsuper.SaveChanges();
                return "Se ha ingresado el computador éxitosamente";

            }
            catch (Exception ex)
            {
                return "El error ocurrido es: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            Computador comp = Consultar(computador.IdComputador);
            try
            {
                if (comp == null)
                {
                    return "El computador no se puede actualizar porque no existe";
                }
                else
                {
                    dbsuper.Computador.AddOrUpdate(computador);
                    dbsuper.SaveChanges();
                    return "El computador ha sido actualizado con éxito";
                }
            } catch (Exception ex) {

                return "No se puede actualizar debido al error: " + ex.Message;
            }
        }

        public Computador Consultar(int id)
        {
            return dbsuper.Computador.FirstOrDefault(c => c.IdComputador == id);
        }

        public string Eliminar()
        {
            Computador comp = Consultar(computador.IdComputador);

            try
            {
                if(comp == null)
                {
                   return "El computador no se puede eliminar porque no existe";
                }
                else
                {
                    dbsuper.Computador.Remove(comp);
                    dbsuper.SaveChanges();
                    return "El computador se eliminó correctamente";
                }

            }
            catch (Exception ex)
            {
                return "No se pudo eliminar debido al error: " + ex.Message;
            }
        }

        public List<Computador> ConsultarTodos()
        {
            return dbsuper.Computador.ToList();
        }
    }
}