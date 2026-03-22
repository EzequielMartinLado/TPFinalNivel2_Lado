using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarca()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.SetearConsulta("select id, descripcion from dbo.Marcas");
                dato.EjecutarLectura();

                while (dato.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)dato.Lector["id"];
                    marca.Descripcion = (string)dato.Lector["descripcion"];
                    listaMarcas.Add(marca);
                }
                return listaMarcas;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dato.CerrarConexion();

            }
        }
    }
}
