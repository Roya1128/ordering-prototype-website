
namespace 程式期末POS點餐系統
{
    partial class 報表
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet4 = new 程式期末POS點餐系統.Database1DataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.userTableAdapter = new 程式期末POS點餐系統.Database1DataSet4TableAdapters.userTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.Database1DataSet4;
            // 
            // Database1DataSet4
            // 
            this.Database1DataSet4.DataSetName = "Database1DataSet4";
            this.Database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.userBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "程式期末POS點餐系統.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 10);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(582, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // 報表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 354);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "報表";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Database1DataSet4 Database1DataSet4;
        private Database1DataSet4TableAdapters.userTableAdapter userTableAdapter;
    }
}