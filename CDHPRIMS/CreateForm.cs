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
    public partial class CreateForm : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = new SqlConnection(Class.utils.connectionString);

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapt = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAddNew_Click(object sender, EventArgs e)
        {
            if (comboBoxUsertype.Text != "" & metroTextBoxFname.Text != "" & metroTextBoxUname.Text != "" & metroTextBoxPassword.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Log (UserType, Fullname, Username, Password) Values (@usertype, @fullname, @username, @password)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@usertype", (comboBoxUsertype.Text));
                cmd.Parameters.AddWithValue("@fullname", (metroTextBoxFname.Text));
                cmd.Parameters.AddWithValue("@username", (metroTextBoxUname.Text));
                cmd.Parameters.AddWithValue("@password", (metroTextBoxPassword.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New User Added!!!");
                comboBoxUsertype.SelectedIndex = -1;
                metroTextBoxFname.Clear();
                metroTextBoxUname.Clear();
                metroTextBoxPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Correct Details!");
            }
        }

        private void metroButtonSign_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();
        }
    }
}
