using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class UserControlPatientPro : UserControl
    {
        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        DataTable dt = new DataTable("Patient");

        CalbayogHospitalSystemEntities cdh;

        public static UserControlPatientPro _instance;


        public static UserControlPatientPro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlPatientPro();
                return _instance;
            }
        }

        public UserControlPatientPro()
        {
            InitializeComponent();
        }

        private void bunifuFlatButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                patientBindingSource.EndEdit();
                cdh.SaveChangesAsync();

                panelNew.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               patientBindingSource.ResetBindings(false);
            }
        }

        private void UserControlPatientPro_Load(object sender, EventArgs e)
        {
            panelNew.Enabled = false;
            cdh = new CalbayogHospitalSystemEntities();

            patientBindingSource.DataSource = cdh.Patients.ToList();
        }

        private void DateTimeBday_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Today.Year - DateTimeBday.Value.Year;
            metroTextBoxAge.Text = Age.ToString();
        }

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelNew.Enabled = true;
            TextBoxHosNo.Focus();
        }

        private void LinkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                panelNew.Enabled = true;
                TextBoxHosNo.Focus();
                Patient p = new Patient();
                cdh.Patients.Add(p);
                patientBindingSource.Add(p);
                patientBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtboxSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
