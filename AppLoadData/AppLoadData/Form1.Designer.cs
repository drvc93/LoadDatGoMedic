
namespace AppLoadData
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnFindFile = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilePath = new DevExpress.XtraEditors.TextEdit();
            this.pgBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblCountRows = new System.Windows.Forms.Label();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.gridviewDataLoad = new DevExpress.XtraGrid.GridControl();
            this.gvDataLoad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreVisitador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCmpCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreMedico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEspecialidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaReporteVisita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraReporteVisita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCycle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCiclo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidaddebioentregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colguia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgWorkerData = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDataLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.Size = new System.Drawing.Size(1110, 60);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Visualizador";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.btnFindFile);
            this.tabFormContentContainer1.Controls.Add(this.txtFilePath);
            this.tabFormContentContainer1.Controls.Add(this.pgBar);
            this.tabFormContentContainer1.Controls.Add(this.lblCountRows);
            this.tabFormContentContainer1.Controls.Add(this.btnLoad);
            this.tabFormContentContainer1.Controls.Add(this.gridviewDataLoad);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 60);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1110, 454);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnFindFile
            // 
            this.btnFindFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFile.ImageOptions.Image")));
            this.btnFindFile.Location = new System.Drawing.Point(918, 3);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(46, 49);
            this.btnFindFile.TabIndex = 5;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(371, 20);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Properties.Appearance.Options.UseFont = true;
            this.txtFilePath.Size = new System.Drawing.Size(541, 32);
            this.txtFilePath.TabIndex = 4;
            // 
            // pgBar
            // 
            this.pgBar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pgBar.Appearance.Options.UseBackColor = true;
            this.pgBar.BarAnimationElementThickness = 2;
            this.pgBar.Location = new System.Drawing.Point(427, 219);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(246, 66);
            this.pgBar.TabIndex = 3;
            this.pgBar.TabStop = false;
            this.pgBar.Text = "progressPanel1";
            this.pgBar.UseWaitCursor = true;
            this.pgBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // lblCountRows
            // 
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRows.Location = new System.Drawing.Point(3, 33);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(0, 23);
            this.lblCountRows.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(970, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 49);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Cargar Info.";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridviewDataLoad
            // 
            this.gridviewDataLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewDataLoad.Location = new System.Drawing.Point(3, 58);
            this.gridviewDataLoad.MainView = this.gvDataLoad;
            this.gridviewDataLoad.Name = "gridviewDataLoad";
            this.gridviewDataLoad.Size = new System.Drawing.Size(1104, 384);
            this.gridviewDataLoad.TabIndex = 0;
            this.gridviewDataLoad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDataLoad});
            // 
            // gvDataLoad
            // 
            this.gvDataLoad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoSupervisor,
            this.colStockDetailId,
            this.colNombreSupervisor,
            this.colIdUser,
            this.colNombreVisitador,
            this.colCmpCode,
            this.colNombreMedico,
            this.colNombreEspecialidad,
            this.colDireccion,
            this.colInstitucion,
            this.colmes,
            this.colFechaReporteVisita,
            this.colHoraReporteVisita,
            this.colIdCycle,
            this.colNombreCiclo,
            this.colNombreProducto,
            this.colCodigoProducto,
            this.colcantidaddebioentregar,
            this.colguia,
            this.collote,
            this.colComent});
            this.gvDataLoad.GridControl = this.gridviewDataLoad;
            this.gvDataLoad.Name = "gvDataLoad";
            // 
            // colCodigoSupervisor
            // 
            this.colCodigoSupervisor.FieldName = "CodigoSupervisor";
            this.colCodigoSupervisor.MinWidth = 25;
            this.colCodigoSupervisor.Name = "colCodigoSupervisor";
            this.colCodigoSupervisor.Visible = true;
            this.colCodigoSupervisor.VisibleIndex = 1;
            this.colCodigoSupervisor.Width = 94;
            // 
            // colStockDetailId
            // 
            this.colStockDetailId.FieldName = "StockDetailId";
            this.colStockDetailId.MinWidth = 25;
            this.colStockDetailId.Name = "colStockDetailId";
            this.colStockDetailId.Visible = true;
            this.colStockDetailId.VisibleIndex = 0;
            this.colStockDetailId.Width = 94;
            // 
            // colNombreSupervisor
            // 
            this.colNombreSupervisor.FieldName = "NombreSupervisor";
            this.colNombreSupervisor.MinWidth = 25;
            this.colNombreSupervisor.Name = "colNombreSupervisor";
            this.colNombreSupervisor.Visible = true;
            this.colNombreSupervisor.VisibleIndex = 2;
            this.colNombreSupervisor.Width = 94;
            // 
            // colIdUser
            // 
            this.colIdUser.FieldName = "IdUser";
            this.colIdUser.MinWidth = 25;
            this.colIdUser.Name = "colIdUser";
            this.colIdUser.Visible = true;
            this.colIdUser.VisibleIndex = 3;
            this.colIdUser.Width = 94;
            // 
            // colNombreVisitador
            // 
            this.colNombreVisitador.FieldName = "NombreVisitador";
            this.colNombreVisitador.MinWidth = 25;
            this.colNombreVisitador.Name = "colNombreVisitador";
            this.colNombreVisitador.Visible = true;
            this.colNombreVisitador.VisibleIndex = 4;
            this.colNombreVisitador.Width = 94;
            // 
            // colCmpCode
            // 
            this.colCmpCode.FieldName = "CmpCode";
            this.colCmpCode.MinWidth = 25;
            this.colCmpCode.Name = "colCmpCode";
            this.colCmpCode.Visible = true;
            this.colCmpCode.VisibleIndex = 5;
            this.colCmpCode.Width = 94;
            // 
            // colNombreMedico
            // 
            this.colNombreMedico.FieldName = "NombreMedico";
            this.colNombreMedico.MinWidth = 25;
            this.colNombreMedico.Name = "colNombreMedico";
            this.colNombreMedico.Visible = true;
            this.colNombreMedico.VisibleIndex = 6;
            this.colNombreMedico.Width = 94;
            // 
            // colNombreEspecialidad
            // 
            this.colNombreEspecialidad.FieldName = "NombreEspecialidad";
            this.colNombreEspecialidad.MinWidth = 25;
            this.colNombreEspecialidad.Name = "colNombreEspecialidad";
            this.colNombreEspecialidad.Visible = true;
            this.colNombreEspecialidad.VisibleIndex = 7;
            this.colNombreEspecialidad.Width = 94;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.MinWidth = 25;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 8;
            this.colDireccion.Width = 94;
            // 
            // colInstitucion
            // 
            this.colInstitucion.FieldName = "Institucion";
            this.colInstitucion.MinWidth = 25;
            this.colInstitucion.Name = "colInstitucion";
            this.colInstitucion.Visible = true;
            this.colInstitucion.VisibleIndex = 9;
            this.colInstitucion.Width = 94;
            // 
            // colmes
            // 
            this.colmes.FieldName = "mes";
            this.colmes.MinWidth = 25;
            this.colmes.Name = "colmes";
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 10;
            this.colmes.Width = 94;
            // 
            // colFechaReporteVisita
            // 
            this.colFechaReporteVisita.FieldName = "FechaReporteVisita";
            this.colFechaReporteVisita.MinWidth = 25;
            this.colFechaReporteVisita.Name = "colFechaReporteVisita";
            this.colFechaReporteVisita.Visible = true;
            this.colFechaReporteVisita.VisibleIndex = 11;
            this.colFechaReporteVisita.Width = 94;
            // 
            // colHoraReporteVisita
            // 
            this.colHoraReporteVisita.FieldName = "HoraReporteVisita";
            this.colHoraReporteVisita.MinWidth = 25;
            this.colHoraReporteVisita.Name = "colHoraReporteVisita";
            this.colHoraReporteVisita.Visible = true;
            this.colHoraReporteVisita.VisibleIndex = 12;
            this.colHoraReporteVisita.Width = 94;
            // 
            // colIdCycle
            // 
            this.colIdCycle.FieldName = "IdCycle";
            this.colIdCycle.MinWidth = 25;
            this.colIdCycle.Name = "colIdCycle";
            this.colIdCycle.Visible = true;
            this.colIdCycle.VisibleIndex = 13;
            this.colIdCycle.Width = 94;
            // 
            // colNombreCiclo
            // 
            this.colNombreCiclo.FieldName = "NombreCiclo";
            this.colNombreCiclo.MinWidth = 25;
            this.colNombreCiclo.Name = "colNombreCiclo";
            this.colNombreCiclo.Visible = true;
            this.colNombreCiclo.VisibleIndex = 14;
            this.colNombreCiclo.Width = 94;
            // 
            // colNombreProducto
            // 
            this.colNombreProducto.FieldName = "NombreProducto";
            this.colNombreProducto.MinWidth = 25;
            this.colNombreProducto.Name = "colNombreProducto";
            this.colNombreProducto.Visible = true;
            this.colNombreProducto.VisibleIndex = 15;
            this.colNombreProducto.Width = 94;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.FieldName = "CodigoProducto";
            this.colCodigoProducto.MinWidth = 25;
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.Visible = true;
            this.colCodigoProducto.VisibleIndex = 16;
            this.colCodigoProducto.Width = 94;
            // 
            // colcantidaddebioentregar
            // 
            this.colcantidaddebioentregar.FieldName = "cantidad debio entregar";
            this.colcantidaddebioentregar.MinWidth = 25;
            this.colcantidaddebioentregar.Name = "colcantidaddebioentregar";
            this.colcantidaddebioentregar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad debio entregar", "SUMA={0:#.##}")});
            this.colcantidaddebioentregar.Visible = true;
            this.colcantidaddebioentregar.VisibleIndex = 17;
            this.colcantidaddebioentregar.Width = 94;
            // 
            // colguia
            // 
            this.colguia.FieldName = "guia";
            this.colguia.MinWidth = 25;
            this.colguia.Name = "colguia";
            this.colguia.Visible = true;
            this.colguia.VisibleIndex = 18;
            this.colguia.Width = 94;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.MinWidth = 25;
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 19;
            this.collote.Width = 94;
            // 
            // colComent
            // 
            this.colComent.FieldName = "Comentario";
            this.colComent.MinWidth = 25;
            this.colComent.Name = "colComent";
            this.colComent.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colComent.Visible = true;
            this.colComent.VisibleIndex = 20;
            this.colComent.Width = 94;
            // 
            // bgWorkerData
            // 
            this.bgWorkerData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerData_DoWork);
            this.bgWorkerData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerData_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 514);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Carga Informacion MM.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.tabFormContentContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDataLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraGrid.GridControl gridviewDataLoad;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDataLoad;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colStockDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUser;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreVisitador;
        private DevExpress.XtraGrid.Columns.GridColumn colCmpCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreMedico;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEspecialidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaReporteVisita;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraReporteVisita;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCycle;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCiclo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidaddebioentregar;
        private DevExpress.XtraGrid.Columns.GridColumn colguia;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private System.Windows.Forms.Label lblCountRows;
        private System.ComponentModel.BackgroundWorker bgWorkerData;
        private DevExpress.XtraWaitForm.ProgressPanel pgBar;
        private DevExpress.XtraGrid.Columns.GridColumn colComent;
        private DevExpress.XtraEditors.SimpleButton btnFindFile;
        private DevExpress.XtraEditors.TextEdit txtFilePath;
    }
}

