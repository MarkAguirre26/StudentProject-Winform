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
    public partial class UserControlPrescription : UserControl
    {
        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        DataTable dt = new DataTable("Prescription");

        CalbayogHospitalSystemEntities cdh;

        public static UserControlPrescription _instance;


        public static UserControlPrescription Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlPrescription();
                return _instance;
            }
        }

        public UserControlPrescription()
        {
            InitializeComponent();
        }

        private void UserControlPrescription_Load(object sender, EventArgs e)
        {
            panelAddPres.Enabled = false;
            cdh = new CalbayogHospitalSystemEntities();

           prescriptionBindingSource.DataSource = cdh.Prescriptions.ToList();
        }

        private void bunifuFlatButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
               prescriptionBindingSource.EndEdit();
                cdh.SaveChangesAsync();

                panelAddPres.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prescriptionBindingSource.ResetBindings(false);
            }
        }

        private void LinkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                panelAddPres.Enabled = true;
                TextBoxPrscriptNo.Focus();
              Prescription prs = new Prescription();
               cdh.Prescriptions.Add(prs);
              prescriptionBindingSource.Add(prs);
           prescriptionBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelAddPres.Enabled = true;
            TextBoxPrscriptNo.Focus();
        }
    }
}
