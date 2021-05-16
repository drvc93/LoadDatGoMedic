using DevExpress.DataAccess.Excel;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace AppLoadData
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        private ExcelDataSource excelDataSource { get; set; }

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
            btnLoad.Enabled = false;
            pgBar.Visible = true;
            bgWorkerData.DoWork += new DoWorkEventHandler(bgWorkerData_DoWork);
            bgWorkerData.RunWorkerAsync();
        }

        public void LoadData()
        {

            excelDataSource = new ExcelDataSource();
            excelDataSource.Name = "Excel Data Source";
            excelDataSource.FileName = @"D:/Regularización_Fausty Jimenez.xlsx";
            ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Historico", "A1:U400000");
            excelDataSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            excelDataSource.Fill();

        }

        private void bgWorkerData_DoWork(object sender, DoWorkEventArgs e)
        {

            LoadData();
        }

        private void bgWorkerData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnLoad.Enabled = true;
            gridviewDataLoad.DataSource = excelDataSource;
            lblCountRows.Text = "Numero de filas :" + gvDataLoad.DataRowCount.ToString();
            pgBar.Visible = false;
        }


    }
}
