using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using AppLoadData.Util;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using AppLoadData.Model;
using System.Collections.Generic;
using AppLoadData.Data;
using System.Text.RegularExpressions;

namespace AppLoadData
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {

        private DataTable dtInfo { get; set; }
        private List<GuiaSap> listGuias { get; set; }
        private DBGoMedic dBGo = new DBGoMedic();
        private static readonly Regex regex = new Regex(@"^\d+$");

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
                MessageBox(Constants.MESSAGE_CAPTION_ERROR, Constants.MESSAGE_FIND_FILE);
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
            listGuias = dBGo.ObtenerGuias();
            dtInfo = ImportExcelXLS(txtFilePath.Text, true);


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

        public void MessageBox(string caption, string message)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 7000;
            args.Caption = caption;
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        public DataTable VerifyData(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var guia = data.Rows[i]["guia"].ToString();
                var lote = data.Rows[i]["lote"].ToString();
                if (string.IsNullOrEmpty(lote) || lote.ToString() == "0" || lote.ToString() == "-")
                {
                    data.Rows[i]["Comentario"] = Constants.BATCH_NOT_VALID;
                    data.Rows[i]["FilaValida"] = false;

                }
                else if (!regex.IsMatch(guia))
                {
                    data.Rows[i]["Comentario"] = Constants.DELIVERY_NOT_VALID;
                    data.Rows[i]["FilaValida"] = false;
                }
                else
                {
                    if (!listGuias.Any(x => x.DeliveryId == Convert.ToInt64(guia) ))
                    {
                        data.Rows[i]["Comentario"] = Constants.DELIVERY_NOT_VALID_BD;
                        data.Rows[i]["FilaValida"] = false;
                    }

                    data.Rows[i]["FilaValida"] = true;
                }

            }

            data.AcceptChanges();

            return data;
        }


        public DataTable ImportExcelXLS(string FileName, bool hasHeaders)
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
                        MessageBox(Constants.MESSAGE_CAPTION_ERROR, ex.Message);
                    }
                }

            }
            outputTable.Columns.Add("Comentario", typeof(string));
            outputTable.Columns.Add("FilaValida", typeof(bool));
            return VerifyData(outputTable);
        }



        private void gvDataLoad_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;

            bool status = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["FilaValida"]));
            if (!status)
            {
                e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                e.Appearance.BackColor2 = Color.FromArgb(150, Color.Salmon);
            }
        }
    }
}
