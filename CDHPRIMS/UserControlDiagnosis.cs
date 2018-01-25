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
    public partial class UserControlDiagnosis : UserControl
    {
        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        DataTable dt = new DataTable("Diagnose");

        CalbayogHospitalSystemEntities cdh;
        
        public static UserControlDiagnosis _instance;


        public static UserControlDiagnosis Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlDiagnosis();
                return _instance;
            }
        }

        public UserControlDiagnosis()
        {
            InitializeComponent();
        }

      
        private void LinkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                panelAdd.Enabled = true;
                textBoxDiagnosNo.Focus();
                Diagnose d = new Diagnose();
               cdh.Diagnoses.Add(d);
              diagnoseBindingSource.Add(d);
              diagnoseBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelAdd.Enabled = true;
            textBoxDiagnosNo.Focus();
        }

        private void bunifuFlatButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
               diagnoseBindingSource.EndEdit();
                cdh.SaveChangesAsync();

                panelAdd.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
              diagnoseBindingSource.ResetBindings(false);
            }
        }

        private void UserControlDiagnosis_Load(object sender, EventArgs e)
        {
            panelAdd.Enabled = false;
            cdh = new CalbayogHospitalSystemEntities();
            diagnoseBindingSource.DataSource = cdh.Diagnoses.ToList();

          
        }

        private void LabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HistoryForm dia = new HistoryForm();
            dia.Show();
        }
    }
}
