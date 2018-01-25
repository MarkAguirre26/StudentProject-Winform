using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;


namespace CDHPRIMS
{
    public partial class MenuForm : MetroFramework.Forms.MetroForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnPatientModule_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UserControlPatientPro.Instance))
            {

                panelMain.Controls.Add(UserControlPatientPro.Instance);
                UserControlPatientPro.Instance.Dock = DockStyle.Fill;
                UserControlPatientPro.Instance.BringToFront();

            }
            else
                UserControlPatientPro.Instance.BringToFront();
        }

        private void BtnDiagnosis_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UserControlDiagnosis.Instance))
            {

                panelMain.Controls.Add(UserControlDiagnosis.Instance);
                UserControlDiagnosis.Instance.Dock = DockStyle.Fill;
                UserControlDiagnosis.Instance.BringToFront();

            }
            else
                UserControlDiagnosis.Instance.BringToFront();
        }

        private void BtnPrescription_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UserControlPrescription.Instance))
            {

                panelMain.Controls.Add(UserControlPrescription.Instance);
                UserControlPrescription.Instance.Dock = DockStyle.Fill;
                UserControlPrescription.Instance.BringToFront();

            }
            else
                UserControlPrescription.Instance.BringToFront();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UserControlReport.Instance))
            {

                panelMain.Controls.Add(UserControlReport.Instance);
                UserControlReport.Instance.Dock = DockStyle.Fill;
                UserControlReport.Instance.BringToFront();

            }
            else
                UserControlReport.Instance.BringToFront();
        }

        private void bunifuFlatButtonID_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UserControlID.Instance))
            {

                panelMain.Controls.Add(UserControlID.Instance);
                UserControlID.Instance.Dock = DockStyle.Fill;
                UserControlID.Instance.BringToFront();

            }
            else
                UserControlID.Instance.BringToFront();
        }
    }
    }

