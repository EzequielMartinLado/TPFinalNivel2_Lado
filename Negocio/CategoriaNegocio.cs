using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategoria()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.SetearConsulta("select id, descripcion from dbo.Categorias");
                dato.EjecutarLectura();
                while (dato.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)dato.Lector["id"];
                    categoria.Descripcion = (string)dato.Lector["descripcion"];
                    listaCategorias.Add(categoria);
                }
                return listaCategorias;
            }
            catch (Exception)
            {
                throw;
            }
            finally { dato.CerrarConexion(); }
        }
    }
}
