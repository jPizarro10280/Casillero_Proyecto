using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IUsuarioDAL UsuarioDAL { get; set; }

        

        private CasilleroProyectoContext _casilleroProyectoContext;

        public UnidadDeTrabajo(CasilleroProyectoContext casilleroProyectoContext, 
            IUsuarioDAL usuarioDAL)
        {
            this._casilleroProyectoContext = casilleroProyectoContext;
            this.UsuarioDAL = usuarioDAL;

        }


        public bool Complete()
        {
            try
            {
                _casilleroProyectoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            this._casilleroProyectoContext.Dispose();
        }
    }
}
