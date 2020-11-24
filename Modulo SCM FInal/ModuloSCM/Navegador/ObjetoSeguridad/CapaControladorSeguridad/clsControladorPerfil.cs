﻿/*
 * Bryan Estuardo Mazariegos Davila
 * 0901-17-1001
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloSeguridad;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaControladorSeguridad
{
    public class clsControladorPerfil
    {
        clsModeloPerfil Modelo = new clsModeloPerfil();

        public int Login(string strUsuario, string strContrasena)
        {
            int estado = Modelo.Login(strUsuario, strContrasena);
            return estado;
        }
        public void BloquearUsuario(string Usuario)
        {
            string Consulta = "UPDATE login set estado_login= 0 where usuario_login= '" + Usuario + "';";
            Modelo.Modificar(Consulta);
        }
        public string NuevoCodigo()
        {
            return Modelo.obtenerNuevocodigo("perfil","pk_id_perfil");
        }
        public OdbcDataReader InsertarPerfil(string Codigo, string Nombre, string Descripcion)
        {
            string Consulta = "INSERT INTO perfil VALUES(" + Codigo + ",'" + Nombre + "','" + Descripcion + "', 1 );";
            return Modelo.Insertar(Consulta);
        }
        public OdbcDataReader Modificar_perfil(string Codigo, string Nombre, string Descripcion, int Estado)
        {
            string Consulta = "UPDATE perfil SET nombre_perfil = '" + Nombre + "', descripcion_perfil = '" + Descripcion + "', estado_perfil = " + Estado + " where pk_id_perfil = " + Codigo + ";";
            return Modelo.Modificar(Consulta);
        }
        public OdbcDataReader Eliminar_perfil(string Codigo)
        {
            string Consulta = "UPDATE perfil SET  estado_Perfil = 0 where pk_id_perfil = " + Codigo + ";";
            return Modelo.Modificar(Consulta);
        }
        public OdbcDataReader consulta(string Tabla,string Campo)
        {
            string Consulta = "SELECT * FROM " + Tabla + " Where "+Campo+" = 1;";
            return Modelo.Consulta(Consulta);
        }
        public OdbcDataReader consultaperfil(string Tabla)
        {
            string Consulta = "SELECT * FROM " + Tabla + ";";
            return Modelo.Consulta(Consulta);
        }
        public OdbcDataReader consulta_ApPerfil(string CodPerfil)
        {
            string Consulta = "SELECT ap.pk_id_aplicacion,ap.nombre_aplicacion FROM aplicacion ap INNER JOIN aplicacion_perfil ap_perfil ON ap.pk_id_aplicacion = ap_perfil.fk_idaplicacion_aplicacion_perfil " +
                              "WHERE ap_perfil.fk_idperfil_aplicacion_perfil = "+CodPerfil;
            return Modelo.Consulta(Consulta);
        }
        public OdbcDataReader consulta_permisos(string CodApli, string CodPerfil)
        {
            string Consulta = "SELECT per.pk_id_permiso, per.insertar_permiso, per.modificar_permiso, per.eliminar_permiso, per.consultar_permiso, per.imprimir_permiso " +
                              "FROM permiso per INNER JOIN aplicacion_perfil app ON per.pk_id_permiso = app.fk_idpermiso_aplicacion_perfil" +
                              " WHERE app.fk_idaplicacion_aplicacion_perfil = "+CodApli+" AND app.fk_idperfil_aplicacion_perfil = "+CodPerfil;
            return Modelo.Consulta(Consulta);
        }
        public OdbcDataReader insertarpermisosPerfil(int permisos0, int permisos1, int permisos2, int permisos3, int permisos4)
        {
            string Cod = Modelo.obtenerNuevocodigo("permiso", "pk_id_permiso");
            string Consulta = "INSERT INTO permiso VALUES(" + Cod + ", " + permisos0 + ", "+ permisos1 + ", "+ permisos2 + ", "+ permisos3 + ", "+ permisos4 + ")";
            return Modelo.Insertar(Consulta);
        }
        public OdbcDataReader insertarApliPerfil(string CodApli, string CodPerfil)
        {
            string Cod = Modelo.obtenerNuevocodigo("aplicacion_perfil", "pk_id_aplicacion_perfil");
            string Consulta = "INSERT INTO aplicacion_perfil VALUES( " + Cod + ", "+ CodApli +", "+ CodPerfil + ", (SELECT MAX(pk_id_permiso) FROM permiso)); ";
            return Modelo.Insertar(Consulta);
        }
        public OdbcDataReader ModificarAppPerfil(int permisos0, int permisos1, int permisos2, int permisos3, int permisos4,string CodPermiso)
        {
            string Consulta = "UPDATE permiso SET insertar_permiso = "+ permisos0+ ", modificar_permiso = " + permisos1 + ", eliminar_permiso = " + permisos2 + ", consultar_permiso = " + permisos3 + ", imprimir_permiso = " + permisos4 + " WHERE pk_id_permiso = "+CodPermiso+";";
            return Modelo.Modificar(Consulta);
        }
        public OdbcDataReader EliminarrAppPerfil(string CodPermiso)
        {
            string Consulta = "UPDATE permiso SET insertar_permiso = 0, modificar_permiso = 0, eliminar_permiso = 0, consultar_permiso = 0, imprimir_permiso =  0 WHERE pk_id_permiso = " + CodPermiso + ";";
            return Modelo.Modificar(Consulta);
        }
    }
}
