namespace Reportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conjuntodeDatos = new Reportes.ConjuntodeDatos();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter = new Reportes.ConjuntodeDatosTableAdapters.DataTable1TableAdapter();
            this.pRODUCTOTableAdapter = new Reportes.ConjuntodeDatosTableAdapters.PRODUCTOTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new Reportes.ConjuntodeDatosTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntodeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.conjuntodeDatos;
            // 
            // conjuntodeDatos
            // 
            this.conjuntodeDatos.DataSetName = "ConjuntodeDatos";
            this.conjuntodeDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.conjuntodeDatos;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.conjuntodeDatos;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 86);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(978, 164);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 39);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(415, 39);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "VENTAS RANGO DE FECHA";
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.pRODUCTOBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Reportes.Informe2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 363);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(978, 163);
            this.reportViewer2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(40, 299);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(307, 22);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 293);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRODUCTOS MAS VENDIDOS ";
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable2BindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Reportes.Informe3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 634);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(978, 246);
            this.reportViewer3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "VENTAS POR CLIENTE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 578);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(748, 572);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataTable2BindingSource1
            // 
            this.dataTable2BindingSource1.DataMember = "DataTable2";
            this.dataTable2BindingSource1.DataSource = this.conjuntodeDatos;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(979, 750);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntodeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ConjuntodeDatos conjuntodeDatos;
        private ConjuntodeDatosTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private ConjuntodeDatosTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dataTable2BindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private ConjuntodeDatosTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
    }
}

