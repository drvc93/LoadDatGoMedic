using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using AppLoadData.Util;
using System.Data;
using System.Data.OleDb;

namespace AppLoadData
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
       
        private DataTable dtInfo { get; set; }
        string sSelectedPath { get; set; }

        public Form1()
        {
            InitializeComponent();
            pgBar.Visible = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // coment
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox( Constants.MESSAGE_CAPTION_ERROR, Constants.MESSAGE_FIND_FILE);
            }
            else
            {
                btnLoad.Enabled = false;
                pgBar.Visible = true;
                bgWorkerData.DoWork += new DoWorkEventHandler(bgWorkerData_DoWork);
                bgWorkerData.RunWorkerAsync();
            }
        }

        public void LoadData()
        {

            /* excelDataSource = new ExcelDataSource();
             excelDataSource.Name = "Excel Data Source";
             excelDataSource.FileName = txtFilePath.Text;
             ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Historico", "A1:U400000");
             excelDataSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
             excelDataSource.Fill();*/
            dtInfo = ImportExcelXLS(txtFilePath.Text , true);

        }

        private void bgWorkerData_DoWork(object sender, DoWorkEventArgs e)
        {

            LoadData();
        }

        private void bgWorkerData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnLoad.Enabled = true;
            gridviewDataLoad.DataSource = dtInfo;
            lblCountRows.Text = "Numero de filas :" + gvDataLoad.DataRowCount.ToString();
            pgBar.Visible = false;
            ///VerifyData();
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel Files (*.*)|*.xlsx;*.xls;";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = choofdlog.FileName;

            }
        }

        public void MessageBox(string caption  , string message)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 7000;
            args.Caption = caption;
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        public void VerifyData ()
        {
            for (int i = 0; i < gvDataLoad.DataRowCount; i++)
            {
                var lote = gvDataLoad.GetRowCellValue(i, "lote").ToString();
                if  (string.IsNullOrEmpty(lote) || lote.ToString() == "0")
                {
                    gvDataLoad.SetRowCellValue(i, "Comentario", "Lote Invalido.");
                    gvDataLoad.RefreshRow(i);

                }

            }
        }


        public  DataTable ImportExcelXLS(string FileName, bool hasHeaders)
        {
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (FileName.Substring(FileName.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";

            DataSet output = new DataSet();
            DataTable outputTable = new DataTable(Constants.EXCEL_SHEET);
            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();

                DataTable schemaTable = conn.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                
                    string sheet = Constants.EXCEL_SHEET;

                    if (!sheet.EndsWith("_"))
                    {
                        try
                        {
                            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                            cmd.CommandType = CommandType.Text;
                           
                            output.Tables.Add(outputTable);
                            new OleDbDataAdapter(cmd).Fill(outputTable);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message + string.Format("Sheet:{0}.File:F{1}", sheet, FileName), ex);
                        }
                    }
                
            }
            return outputTable;
        }
    }
}
