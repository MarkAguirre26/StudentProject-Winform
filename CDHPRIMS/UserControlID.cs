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
    public partial class UserControlID : UserControl
    {
        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        DataTable dt = new DataTable("Patient");

        CalbayogHospitalSystemEntities cdh;



        public static UserControlID _instance;

        public static UserControlID Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlID();
                return _instance;
            }
        }

        public UserControlID()
        {
            InitializeComponent();

        }

        private void UserControlID_Load(object sender, EventArgs e)
        {
            cdh = new CalbayogHospitalSystemEntities();
            patientBindingSource.DataSource = cdh.Patients.ToList();
        }


        private void LinkPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IDPrintable id = new IDPrintable();
            id.Show();
        }
        }
    }
        
    

           
