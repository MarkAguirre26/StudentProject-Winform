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
    public partial class PatientsReportPrint : MetroFramework.Forms.MetroForm
    {
        public PatientsReportPrint()
        {
            InitializeComponent();
        }

        private void PatientsReportPrint_Load(object sender, EventArgs e)
        {

          


        }


        void loadReportA()
        {
            bunifuFlatButton2.Visible = true;

             DataTable PatientInfo = ClassSql.MsSql.Table("SELECT dbo.Patient.HospitalNo, dbo.Patient.Firstname, dbo.Patient.Midname, dbo.Patient.Lastname, SUBSTRING ( CAST ( dbo.Patient.Birthday AS VARCHAR ), 1, 10 ) Birthday, dbo.Patient.Age, dbo.Patient.Birthplace, dbo.Patient.City, dbo.Patient.Barangay, dbo.Patient.Gender, dbo.Patient.Status, dbo.Patient.Father, dbo.Patient.Mother FROM dbo.Patient WHERE dbo.Patient.HospitalNo = "+TxtboxSearch.Text+"");
            DataTable Diagnosis = ClassSql.MsSql.Table("SELECT dbo.Diagnose.DiagnosisNo, dbo.Diagnose.HospitalNo, LEFT ( CONVERT ( VARCHAR, CONVERT ( DATE, dbo.Diagnose.DateAdmitted ), 120 ), 10 ) DateAdmitted, LEFT ( CONVERT ( VARCHAR, CONVERT ( DATE, dbo.Diagnose.DateDischarge ), 120 ), 10 ) DateDischarge, dbo.Diagnose.AdmissionType, dbo.Diagnose.Physician, dbo.Diagnose.AdmissionDiagnosis, dbo.Diagnose.PrincipalDiagnosis, dbo.Diagnose.PrinProce, dbo.Diagnose.Disposition, dbo.Diagnose.Results FROM dbo.Diagnose WHERE dbo.Diagnose.HospitalNo = "+ TxtboxSearch.Text +" ORDER BY DiagnosisNo ASC");
            DataTable Presciption = ClassSql.MsSql.Table("SELECT dbo.Prescription.PrescriptNo, dbo.Prescription.DiagnosisNo, dbo.Prescription.HospitalNo, dbo.Prescription.Medications, LEFT ( CONVERT ( VARCHAR, CONVERT ( DATE, dbo.Prescription.DatePrescribed ), 120 ), 10 ) DatePrescribed FROM dbo.Prescription WHERE dbo.Prescription.HospitalNo = "+TxtboxSearch.Text+" ORDER BY PrescriptNo ASC");

            ReportDataSource ds_PatientInfo = new ReportDataSource("DataSet1", PatientInfo);
            ReportDataSource ds_Presciptions = new ReportDataSource("DataSet3", Presciption);
            ReportDataSource ds_Diagnosis = new ReportDataSource("DataSet2", Diagnosis);
            reportViewePatients.LocalReport.DataSources.Add(ds_Diagnosis);
            reportViewePatients.LocalReport.DataSources.Add(ds_PatientInfo);          
            reportViewePatients.LocalReport.DataSources.Add(ds_Presciptions);
            reportViewePatients.LocalReport.ReportPath = Class.utils.AppPath.Replace("bin", "") + "ReportPatientRecord.rdlc";                                         
            ReportviewerSetting();

        }
        void ReportviewerSetting()
        {
            this.reportViewePatients.RefreshReport();
            reportViewePatients.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewePatients.ZoomMode = ZoomMode.Percent;
            reportViewePatients.ZoomPercent = 100;

        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadReportA();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            using (Form1 f = new Form1())
            {
                f.Tag = TxtboxSearch.Text;
                f.ShowDialog();
            }
        
        }

        private void TxtboxSearch_Click(object sender, EventArgs e)
        {
            if(TxtboxSearch.Text == "")
            {
                bunifuFlatButton2.Visible = false;
            }
        }
    }
}
