using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Globalization;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace CDHPRIMS
{
    public partial class IDPrintable : MetroFramework.Forms.MetroForm
    {
      

        public IDPrintable()
        {
            InitializeComponent();
            
        }

        private void IDPrintable_Load(object sender, EventArgs e)
        {
            
        }

        void loadReport()
        {


            DataTable PatientInfo = ClassSql.MsSql.Table("exec PatientInfo '" + TxtboxSearch.Text + "'");  
            ReportDataSource ds_PatientInfo = new ReportDataSource("DataSet1", PatientInfo);
            reportViewerID.LocalReport.DataSources.Add(ds_PatientInfo);
            reportViewerID.LocalReport.ReportPath = Class.utils.AppPath.Replace("bin", "") + "ReportID.rdlc";
            ReportviewerSetting();
        }

        void ReportviewerSetting()
        {
            this.reportViewerID.RefreshReport();
            reportViewerID.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewerID.ZoomMode = ZoomMode.Percent;
            reportViewerID.ZoomPercent = 100;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
