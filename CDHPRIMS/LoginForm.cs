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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassSql.MsSql.connectionString = Class.utils.connectionString;

        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {

            if ((comboBoxUtype.Text != "") && (metroTextBoxUsername.Text != "") && (metroTextBoxPword.Text != ""))
            {
                            
                DataTable dt = ClassSql.MsSql.Table("select * from Log where UserType = '"+ this.comboBoxUtype.Text + "' and Username = '"+ metroTextBoxUsername.Text + "' and Password = '"+ metroTextBoxPword.Text + "'");
                if(dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Login Successfully Done");
                    MenuForm home = new MenuForm();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Access Denied, Password and Username Mismatched");
                }
            }
            else { MessageBox.Show("Enter username and password"); }
        }

        private void metroButtonCreate_Click(object sender, EventArgs e)
        {
            CreateForm newuser = new CreateForm();
            this.Hide();
            newuser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PatientsReportPrint().ShowDialog();
        }
    }
}
