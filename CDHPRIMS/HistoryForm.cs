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

namespace CDHPRIMS
{
    public partial class HistoryForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        DataTable dt = new DataTable();

        CalbayogHospitalSystemEntities cdh;

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxHosNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string query = "Select Firstname,Midname, Lastname, Birthday, Age, Birthplace from Patient where HospitalNo LIKE '%" + TextBoxHosNo.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();

                metroGridDiagnose.DataSource = null;
                metroGridDiagnose.Rows.Clear();
                metroGridDiagnose.DataBindings.Clear();


                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        TextBoxFrstnm.Text = (sdr["Firstname"].ToString());
                        TextBoxMdnm.Text = (sdr["Midname"].ToString());
                        TextBoxLstnm.Text = (sdr["Lastname"].ToString());
                        DateTimeBday.Value = Convert.ToDateTime(sdr["Birthday"].ToString());
                        metroTextBoxAge.Text = (sdr["Age"].ToString());
                        TextBoxBplace.Text = (sdr["Birthplace"].ToString());


                    }
                    else
                    {

                    }
                }
                con.Close();

                adapt = new SqlDataAdapter("select * from Diagnose where HospitalNo = '" + TextBoxHosNo.Text + "'", con);
                metroGridDiagnose.DataBindings.Clear();
                adapt.Fill(dt);
                metroGridDiagnose.DataSource = dt;

                {

                    //adapt = new SqlDataAdapter("select * from Prescription where DiagnosisNo = '" + TextBoxHosNo.Text + "'", con);

                    //adapt.Fill(dt);
                    //metroGridPres.DataSource = dt;
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void metroGridDiagnose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void metroGridPres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGridDiagnose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxPrscriptNo.Text = metroGridDiagnose.SelectedRows[0].Cells[0].Value.ToString();
            textBoxADia.Text = metroGridDiagnose.SelectedRows[0].Cells[6].Value.ToString();
            textBoxPDia.Text = metroGridDiagnose.SelectedRows[0].Cells[7].Value.ToString();

            //DataView dv = dt.DefaultView;
            //BindingSource bs = new BindingSource();
            if (this.metroGridPres.DataSource != null)
            {
                this.metroGridPres.DataSource = null;
            }
            else
            {
                this.metroGridPres.Rows.Clear();
            }
            con.Open();
            
            adapt = new SqlDataAdapter("select * from Prescription where DiagnosisNo  = '" + TextBoxPrscriptNo.Text + "'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            metroGridPres.DataSource = dt;
            con.Close();
            //dv.RowFilter = string.Format("DiagnosisNo = '%{0}%'", TextBoxPrscriptNo.Text);
            // metroGridPres.DataSource = dv.ToTable();
            
        }

        private void LinkPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientsReportPrint rep = new PatientsReportPrint();
            rep.Show();
        }
    }
}
