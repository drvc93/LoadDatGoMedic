using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using AppLoadData.Util;

namespace AppLoadData
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        private ExcelDataSource excelDataSource { get; set; }
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

            excelDataSource = new ExcelDataSource();
            excelDataSource.Name = "Excel Data Source";
            excelDataSource.FileName = txtFilePath.Text;
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
    }
}
