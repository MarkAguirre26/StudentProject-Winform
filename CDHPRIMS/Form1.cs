using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDHPRIMS
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void loadReportB()
        {


            DataTable PatientInfo = ClassSql.MsSql.Table("SELECT dbo.Patient.HospitalNo, dbo.Patient.Firstname, dbo.Patient.Midname, dbo.Patient.Lastname, SUBSTRING ( CAST ( dbo.Patient.Birthday AS VARCHAR ), 1, 10 ) Birthday, dbo.Patient.Age, dbo.Patient.Birthplace, dbo.Patient.City, dbo.Patient.Barangay, dbo.Patient.Gender, dbo.Patient.Status, dbo.Patient.Father, dbo.Patient.Mother FROM dbo.Patient WHERE dbo.Patient.HospitalNo = " + this.Tag.ToString() + "");
            DataTable Diagnosis = ClassSql.MsSql.Table("SELECT dbo.Diagnose.DiagnosisNo, dbo.Diagnose.HospitalNo, LEFT ( CONVERT ( VARCHAR, CONVERT ( DATE, dbo.Diagnose.DateAdmitted ), 120 ), 10 ) DateAdmitted, LEFT ( CONVERT ( VARCHAR, CONVERT ( DATE, dbo.Diagnose.DateDischarge ), 120 ), 10 ) DateDischarge, dbo.Diagnose.AdmissionType, dbo.Diagnose.Physician, dbo.Diagnose.AdmissionDiagnosis, dbo.Diagnose.PrincipalDiagnosis, dbo.Diagnose.PrinProce, dbo.Diagnose.Disposition, dbo.Diagnose.Results FROM dbo.Diagnose WHERE dbo.Diagnose.DiagnosisNo = " + metroTextBox1.Text + "");
            DataTable Presciption = ClassSql.MsSql.Table("SELECT dbo.Prescription.PrescriptNo, dbo.Prescription.DiagnosisNo, dbo.Prescription.HospitalNo, dbo.Prescription.Medications, LEFT ( CONVERT ( VARCHAR, CONVERT ( DATE, dbo.Prescription.DatePrescribed ), 120 ), 10 ) DatePrescribed FROM dbo.Prescription WHERE dbo.Prescription.DiagnosisNo = " + metroTextBox1.Text + " ORDER BY PrescriptNo ASC");

            ReportDataSource ds_PatientInfo = new ReportDataSource("DataSet1", PatientInfo);
            ReportDataSource ds_Presciptions = new ReportDataSource("DataSet3", Presciption);



            reportViewePatients.LocalReport.DataSources.Add(ds_PatientInfo);
            reportViewePatients.LocalReport.DataSources.Add(ds_Presciptions);
            reportViewePatients.LocalReport.ReportPath = Class.utils.AppPath.Replace("bin", "") + "DiagnosisReport.rdlc";
            foreach(DataRow dr in Diagnosis.Rows)
            {
                ReportParameter[] parameters = new ReportParameter[11];
                parameters[0] = new ReportParameter("DiagnosisNo", dr["DiagnosisNo"].ToString());
                parameters[1] = new ReportParameter("DateAdmitted", dr["DateAdmitted"].ToString());
                parameters[2] = new ReportParameter("AdmissionType", dr["AdmissionType"].ToString());
                parameters[3] = new ReportParameter("AdmissionDiagnosis", dr["AdmissionDiagnosis"].ToString());
                parameters[4] = new ReportParameter("PrincipalDiagnosis", dr["PrincipalDiagnosis"].ToString());
                parameters[5] = new ReportParameter("PrinProce", dr["PrinProce"].ToString());
                parameters[6] = new ReportParameter("HospitalNo", dr["HospitalNo"].ToString());
                parameters[7] = new ReportParameter("DateDischarge", dr["DateDischarge"].ToString());
                parameters[8] = new ReportParameter("Physician", dr["Physician"].ToString());
                parameters[9] = new ReportParameter("Results", dr["Results"].ToString());
                parameters[10] = new ReportParameter("Disposition", dr["Disposition"].ToString());
                reportViewePatients.LocalReport.SetParameters(parameters);
            }

           


           


            ReportviewerSetting();
        }

        void ReportviewerSetting()
        {
            this.reportViewePatients.RefreshReport();
            reportViewePatients.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewePatients.ZoomMode = ZoomMode.Percent;
            reportViewePatients.ZoomPercent = 100;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            loadReportB();
        }
    }
}
