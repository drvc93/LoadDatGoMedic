using AppLoadData.Util;
using System.Data.SqlClient;
using AppLoadData.Model;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System.Data;
using System;

namespace AppLoadData.Data
{
    public class DBGoMedic
    {
        private readonly SqlConnection conn = new SqlConnection(Constants.SQL_CONEXION);
        public DBGoMedic() { }

        public List<GuiaSap> ObtenerGuias()
        {
            conn.Open();
            var guias = conn.Query<GuiaSap>("  select * from QVISIT.DeliverySap").ToList();
            conn.Close();

            return guias;
        }

        public string InsertarData(DataTable dt)
        {
            string result = Constants.INSERT_OK;

            try
            {
                SqlBulkCopy objbulk = new SqlBulkCopy(conn);
                //assign Destination table name  
                objbulk.DestinationTableName = "TempStockDetail";
                objbulk.ColumnMappings.Add("StockDetailId", "StockDetailId");
                objbulk.ColumnMappings.Add("CodigoSupervisor", "CodigoSupervisor");
                objbulk.ColumnMappings.Add("NombreSupervisor", "NombreSupervisor");
                objbulk.ColumnMappings.Add("IdUser", "IdUser");
                objbulk.ColumnMappings.Add("NombreVisitador", "NombreVisitador");
                objbulk.ColumnMappings.Add("CmpCode", "CmpCode");
                objbulk.ColumnMappings.Add("NombreMedico", "NombreMedico");
                objbulk.ColumnMappings.Add("NombreEspecialidad", "NombreEspecialidad");
                objbulk.ColumnMappings.Add("Direccion", "Direccion");
                objbulk.ColumnMappings.Add("Institucion", "Institucion");
                objbulk.ColumnMappings.Add("FechaReporteVisita", "FechaReporteVisita");
                objbulk.ColumnMappings.Add("HoraReporteVisita", "HoraReporteVisita");
                objbulk.ColumnMappings.Add("IdCycle", "IdCycle");
                objbulk.ColumnMappings.Add("NombreCiclo", "NombreCiclo");
                objbulk.ColumnMappings.Add("CodigoProducto", "CodigoProducto");
                objbulk.ColumnMappings.Add("cantidad debio entregar", "CantidadDebioEntregar");
                objbulk.ColumnMappings.Add("guia", "guia");
                objbulk.ColumnMappings.Add("lote", "lote");

                conn.Open();
                //insert bulk Records into DataBase.  
                objbulk.WriteToServer(dt);
                conn.Close();
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string DeleteTemporalTable()
        {
            string result = Constants.OPERATION_OK;
            try {

            conn.Open();
            conn.Execute("DELETE  dbo.TempStockDetail");
            conn.Close();
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string UpdateStock()
        {
            string result = Constants.INSERT_OK;
            try
            {

                conn.Open();
               var rowsaffect = conn.Execute(" exec QVISIT.usp_updateStock_MedicalVisits");
                conn.Close();
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }


     
    }
}
