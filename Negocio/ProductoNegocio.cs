using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Xml.Linq;
using System.Data.Common;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> ListarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.SetearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio from dbo.ARTICULOS A, dbo.CATEGORIAS C, dbo.MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id");
                dato.EjecutarLectura();

                while (dato.Lector.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = (int)dato.Lector["Id"];
                    producto.Codigo = (string)dato.Lector["Codigo"];
                    producto.Nombre = (string)dato.Lector["Nombre"];
                    producto.Descripcion = (string)dato.Lector["Descripcion"];

                    if (!(dato.Lector["ImagenUrl"] is DBNull))
                        producto.ImagenUrl= (string)dato.Lector["ImagenUrl"];

                    // Opción A: convertir desde decimal a double
                    producto.Precio = Convert.ToDouble((decimal)dato.Lector["Precio"]);

                    // Opción B: usar Convert.ToDouble directamente (maneja varios tipos)
                    // producto.Precio = Convert.ToDouble(dato.Lector["Precio"]);
                    

                    producto.Marca = new Marca();
                    producto.Marca.Id = (int)dato.Lector["IdMarca"];
                    producto.Marca.Descripcion = (string)dato.Lector["Marca"];
                    producto.Categoria = new Categoria();
                    producto.Categoria.Id = (int)dato.Lector["IdCategoria"];
                    producto.Categoria.Descripcion = (string)dato.Lector["Categoria"];
                    listaProductos.Add(producto);
                }
                return listaProductos;
            }
            catch (Exception)
            {

                throw;
            }
            finally { dato.CerrarConexion(); }

        }

        public void agregarProducto(Producto nuevo)
        {
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.SetearConsulta("insert into dbo.ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, ImagenUrl) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio, @ImagenUrl)");
                dato.AgregarParametro("@Codigo", nuevo.Codigo);
                dato.AgregarParametro("@Nombre", nuevo.Nombre);
                dato.AgregarParametro("@Descripcion", nuevo.Descripcion);
                dato.AgregarParametro("@IdMarca", nuevo.Marca.Id);
                dato.AgregarParametro("@IdCategoria", nuevo.Categoria.Id);
                dato.AgregarParametro("@Precio", nuevo.Precio);
                dato.AgregarParametro("@ImagenUrl", nuevo.ImagenUrl);
                dato.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { dato.CerrarConexion(); }
        }

        public void ModificarProducto(Producto producto)
        {
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.SetearConsulta("update dob.ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio, ImagenUrl = @ImagenUrl where Id = @Id");
                dato.AgregarParametro("@Codigo", producto.Codigo);
                dato.AgregarParametro("@Nombre", producto.Nombre);
                dato.AgregarParametro("@Descripcion", producto.Descripcion);
                dato.AgregarParametro("@IdMarca", producto.Marca.Id);
                dato.AgregarParametro("@IdCategoria", producto.Categoria.Id);
                dato.AgregarParametro("@Precio", producto.Precio);
                dato.AgregarParametro("@ImagenUrl", producto.ImagenUrl);
                dato.AgregarParametro("@Id", producto.Id);
                dato.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { dato.CerrarConexion(); }
        }

        public void eliminarProducto(int id)
        {
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.SetearConsulta("delete from dbo.ARTICULOS where Id = @Id");
                dato.AgregarParametro("@Id", id);
                dato.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { dato.CerrarConexion(); }
        }

        /* public List<Producto> Filtrar(string categoria, string marca)
         {
             List<Producto> listaProductos = new List<Producto>();
             AccesoDato dato = new AccesoDato();
             try
             {
                 string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio from dbo.ARTICULOS A, dbo.CATEGORIAS C, dbo.MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id and ";
                 consulta += "C.Descripcion = '" + categoria.ToString() + "' and M.Descripcion = '" + marca.ToString() + "'";



                 dato.SetearConsulta(consulta);
                 dato.EjecutarLectura();
                 while (dato.Lector.Read())
                 {
                     Producto producto = new Producto();
                     producto.Id = (int)dato.Lector["Id"];
                     producto.Codigo = (string)dato.Lector["Codigo"];
                     producto.Nombre = (string)dato.Lector["Nombre"];
                     producto.Descripcion = (string)dato.Lector["Descripcion"];
                     if (!(dato.Lector["ImagenUrl"] is DBNull))
                         producto.ImagenUrl = (string)dato.Lector["ImagenUrl"];
                     // Opción A: convertir desde decimal a double
                     producto.Precio = Convert.ToDouble((decimal)dato.Lector["Precio"]);
                     // Opción B: usar Convert.ToDouble directamente (maneja varios tipos)
                     // producto.Precio = Convert.ToDouble(dato.Lector["Precio"]);
                     producto.Marca = new Marca();
                     producto.Marca.Id = (int)dato.Lector["IdMarca"];
                     producto.Marca.Descripcion = (string)dato.Lector["Marca"];
                     producto.Categoria = new Categoria();
                     producto.Categoria.Id = (int)dato.Lector["IdCategoria"];
                     producto.Categoria.Descripcion = (string)dato.Lector["Categoria"];
                     listaProductos.Add(producto);
                 }
                 return listaProductos;



             }
             catch (Exception)
             {

                 throw;
             }

         }*/
        public List<Producto> Filtrar(int? idCategoria, int? idMarca)
        {
            List<Producto> listaProductos = new List<Producto>();
            AccesoDato dato = new AccesoDato();
            try
            {
                string consulta = @"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, 
                                   M.Descripcion Marca, A.IdMarca, 
                                   C.Descripcion Categoria, A.IdCategoria, 
                                   A.ImagenUrl, A.Precio 
                            FROM dbo.ARTICULOS A, dbo.CATEGORIAS C, dbo.MARCAS M 
                            WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id";

                if (idCategoria.HasValue)
                    consulta += " AND A.IdCategoria = @IdCategoria";

                if (idMarca.HasValue)
                    consulta += " AND A.IdMarca = @IdMarca";

                dato.SetearConsulta(consulta);

                if (idCategoria.HasValue)
                    dato.AgregarParametro("@IdCategoria", idCategoria.Value);

                if (idMarca.HasValue)
                    dato.AgregarParametro("@IdMarca", idMarca.Value);

                dato.EjecutarLectura();

                while (dato.Lector.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = (int)dato.Lector["Id"];
                    producto.Codigo = (string)dato.Lector["Codigo"];
                    producto.Nombre = (string)dato.Lector["Nombre"];
                    producto.Descripcion = (string)dato.Lector["Descripcion"];
                    if (!(dato.Lector["ImagenUrl"] is DBNull))
                        producto.ImagenUrl = (string)dato.Lector["ImagenUrl"];
                    producto.Precio = Convert.ToDouble((decimal)dato.Lector["Precio"]);
                    producto.Marca = new Marca();
                    producto.Marca.Id = (int)dato.Lector["IdMarca"];
                    producto.Marca.Descripcion = (string)dato.Lector["Marca"];
                    producto.Categoria = new Categoria();
                    producto.Categoria.Id = (int)dato.Lector["IdCategoria"];
                    producto.Categoria.Descripcion = (string)dato.Lector["Categoria"];
                    listaProductos.Add(producto);
                }
                return listaProductos;
            }
            catch (Exception)
            {
                throw;
            }
            finally { dato.CerrarConexion(); }
        }


    }
}
