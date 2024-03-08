using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GuiaCuatro
{
    internal class conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;

        public void conec()
        {
            servidor = "FRANCISCO\\SQLEXPRESS";
            db = "BD_Sucarnet";
            usuario = "sa";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;
        }
    }
}
