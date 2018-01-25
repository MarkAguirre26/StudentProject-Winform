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
    public partial class UserControlReport : UserControl
    {
        public static UserControlReport _instance;


        public static UserControlReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlReport();
                return _instance;
            }
        }

        public UserControlReport()
        {
            InitializeComponent();
        }

        private void LinkPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void UserControlReport_Load(object sender, EventArgs e)
        {

        }
    }
}
