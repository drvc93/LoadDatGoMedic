using AppLoadData.Util;
using System.Data.SqlClient;
using AppLoadData.Model;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace AppLoadData.Data
{
    public class DBGoMedic
    {
        private readonly SqlConnection conn = new SqlConnection(Constants.SQL_CONEXION);
        public DBGoMedic () {}

        public  List<GuiaSap> ObtenerGuias ()
        {
            conn.Open();
            var  guias = conn.Query<GuiaSap>("  select * from QVISIT.DeliverySap").ToList();
            conn.Close();

            return guias;
        }
    }
}
