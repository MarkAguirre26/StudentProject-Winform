namespace CDHPRIMS
{
    partial class UserControlPatientPro
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPatientPro));
            this.TextBoxLstnm = new System.Windows.Forms.TextBox();
            this.TextBoxMdnm = new System.Windows.Forms.TextBox();
            this.TextBoxFrstnm = new System.Windows.Forms.TextBox();
            this.TextBoxHosNo = new System.Windows.Forms.TextBox();
            this.TextBoxBplace = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.ComboBoxBrgy = new System.Windows.Forms.ComboBox();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.metroTextBoxMother = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFather = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelNew = new System.Windows.Forms.Panel();
            this.metroTextBoxAge = new MetroFramework.Controls.MetroTextBox();
            this.DateTimeBday = new System.Windows.Forms.DateTimePicker();
            this.LinkNew = new System.Windows.Forms.LinkLabel();
            this.LinkEdit = new System.Windows.Forms.LinkLabel();
            this.TxtboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGridProfile = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuFlatButtonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLstnm
            // 
            this.TextBoxLstnm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Lastname", true));
            this.TextBoxLstnm.Location = new System.Drawing.Point(114, 98);
            this.TextBoxLstnm.Name = "TextBoxLstnm";
            this.TextBoxLstnm.Size = new System.Drawing.Size(140, 20);
            this.TextBoxLstnm.TabIndex = 3;
            // 
            // TextBoxMdnm
            // 
            this.TextBoxMdnm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Midname", true));
            this.TextBoxMdnm.Location = new System.Drawing.Point(114, 71);
            this.TextBoxMdnm.Name = "TextBoxMdnm";
            this.TextBoxMdnm.Size = new System.Drawing.Size(140, 20);
            this.TextBoxMdnm.TabIndex = 2;
            // 
            // TextBoxFrstnm
            // 
            this.TextBoxFrstnm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Firstname", true));
            this.TextBoxFrstnm.Location = new System.Drawing.Point(114, 42);
            this.TextBoxFrstnm.Name = "TextBoxFrstnm";
            this.TextBoxFrstnm.Size = new System.Drawing.Size(140, 20);
            this.TextBoxFrstnm.TabIndex = 1;
            // 
            // TextBoxHosNo
            // 
            this.TextBoxHosNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "HospitalNo", true));
            this.TextBoxHosNo.Location = new System.Drawing.Point(114, 13);
            this.TextBoxHosNo.Name = "TextBoxHosNo";
            this.TextBoxHosNo.Size = new System.Drawing.Size(140, 20);
            this.TextBoxHosNo.TabIndex = 0;
            // 
            // TextBoxBplace
            // 
            // 
            // 
            // 
            this.TextBoxBplace.CustomButton.Image = null;
            this.TextBoxBplace.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.TextBoxBplace.CustomButton.Name = "";
            this.TextBoxBplace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxBplace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxBplace.CustomButton.TabIndex = 1;
            this.TextBoxBplace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxBplace.CustomButton.UseSelectable = true;
            this.TextBoxBplace.CustomButton.Visible = false;
            this.TextBoxBplace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Birthplace", true));
            this.TextBoxBplace.Lines = new string[0];
            this.TextBoxBplace.Location = new System.Drawing.Point(114, 183);
            this.TextBoxBplace.MaxLength = 32767;
            this.TextBoxBplace.Name = "TextBoxBplace";
            this.TextBoxBplace.PasswordChar = '\0';
            this.TextBoxBplace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxBplace.SelectedText = "";
            this.TextBoxBplace.SelectionLength = 0;
            this.TextBoxBplace.SelectionStart = 0;
            this.TextBoxBplace.ShortcutsEnabled = true;
            this.TextBoxBplace.Size = new System.Drawing.Size(140, 23);
            this.TextBoxBplace.TabIndex = 6;
            this.TextBoxBplace.UseSelectable = true;
            this.TextBoxBplace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxBplace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(6, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Birthplace";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Status", true));
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Status", true));
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource, "Status", true));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Annuled",
            "Separated",
            "Divorced",
            "Live-In",
            "Widow"});
            this.comboBoxStatus.Location = new System.Drawing.Point(114, 294);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(140, 21);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Gender", true));
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Gender", true));
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource, "Gender", true));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(114, 267);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(96, 21);
            this.comboBoxGender.TabIndex = 9;
            // 
            // ComboBoxBrgy
            // 
            this.ComboBoxBrgy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Barangay", true));
            this.ComboBoxBrgy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Barangay", true));
            this.ComboBoxBrgy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource, "Barangay", true));
            this.ComboBoxBrgy.FormattingEnabled = true;
            this.ComboBoxBrgy.Items.AddRange(new object[] {
            "Acedillo",
            "Aguit-itan (Pob.)",
            "Alibaba",
            "Amampacang",
            "Anislag",
            "Awang East (Pob.)",
            "Awang West (Pob.)",
            "Baay",
            "Bacjao",
            "Bagacay",
            "Bagong Lipunan",
            "Baja",
            "Balatgoti",
            "Balocawe",
            "Balud (Proper)",
            "Balus Poblacion",
            "Bante",
            "Bantian",
            "Baquiw",
            "Baras",
            "Basud",
            "Basud (Pob.)",
            "Bayo",
            "Begaho",
            "Biasong",
            "Biasong 2",
            "Binaliw",
            "Bontay",
            "Buenavista",
            "Buenavista",
            "Bugtong",
            "Cabacungan",
            "Cabatuan",
            "Cabicahan",
            "Cabugawan",
            "Cabunga-an",
            "Cacaransan",
            "Cag anahaw",
            "Cag anibong",
            "Cag olango",
            "Cagbanayacao",
            "Cagbayang",
            "Cagbilwang",
            "Cagbuburac",
            "Caglanipao Sur",
            "Cagmanipes Norte",
            "Cagmanipes Sur",
            "Cagnipa",
            "Cagsalaosao",
            "Cahumpan",
            "Calucnayan",
            "Cangomaod",
            "Canhumadac",
            "Capacuhan",
            "Capoocan",
            "Carayman",
            "Carmen",
            "Catabunan",
            "Caybago",
            "Central (Pob.)",
            "Cogon",
            "Costa Rica",
            "Costa Rica 2",
            "Curocawayan",
            "Dagum",
            "Danao I",
            "Danao II",
            "Dawo",
            "De Victoria",
            "Dinabongan",
            "Dinagan",
            "Dinawacan",
            "Esperanza",
            "Gabay",
            "Gadgaran",
            "Gasdo",
            "Geraga-an",
            "Guimbaoyan Norte",
            "Guimbaoyan Sur",
            "Guin-ansan",
            "Guinbarucan",
            "Guin-on",
            "Hamorawon",
            "Helino",
            "Hibabngan",
            "Hibatang",
            "Higasaan",
            "Himalandrog",
            "Hugon Rosales",
            "Ilijan",
            "Ilo (Pob.)",
            "Imelda (Badjang)",
            "Jacinto",
            "Jimautan",
            "Jose Rono",
            "Kalilihan",
            "Kerikite",
            "Kilikili",
            "La Paz",
            "Labangbaybay",
            "Langoyon",
            "Lapaan",
            "Libertad",
            "Limarayon",
            "Lobelobe",
            "Longsob",
            "Lonoy",
            "Looc",
            "Luna",
            "Lunang 1",
            "Lunang 2",
            "Mabini I (Calbayog District)",
            "Mabini II (Oquendo District)",
            "Mabuhay",
            "Macatingog",
            "Magsaysay",
            "Mag-ubay",
            "Maguino-o",
            "Malaga",
            "Malajog",
            "Malayog",
            "Malobago",
            "Malopalo",
            "Mancol",
            "Mantaong (Oquendo District)",
            "Manuel Barral, Sr.",
            "Marasbaras",
            "Marcatubig",
            "Mataluto",
            "Matobato",
            "Mawacat",
            "Maybog",
            "Maysalong",
            "Migara",
            "Monbon",
            "Nabang",
            "Naga",
            "Naguma",
            "Navarro",
            "Nijaga",
            "Nipa",
            "Oboob",
            "Obrero",
            "Olera",
            "Oquendo (Pob.)",
            "Osmena",
            "Pagbalican",
            "Palanas",
            "Palanogan",
            "Panjobjoban 1",
            "Panjobjoban 2",
            "Panlayahan",
            "Panonongan",
            "Panoypoy",
            "Pantalan",
            "Patong",
            "Payahan",
            "Pena",
            "Pilar",
            "Pinamorotan",
            "Pinanangnan ",
            "Poblacion",
            "Pulangbato",
            "Quezon",
            "Rawis",
            "Rizal I (Calbayog District)",
            "Rizal II (Oquendo District)",
            "Rono",
            "Roxas I (Calbayog District)",
            "Roxas II (Oquendo District)",
            "Saljag (Baut)",
            "Salvacion",
            "San Antonio",
            "San Isidro",
            "San Isidro",
            "San Joaquin",
            "San Jose",
            "San Jose ",
            "San Jose (Pob.)",
            "San Policarpio",
            "San Rufino",
            "San Vicente",
            "Saputan",
            "Sevilla",
            "Sigo",
            "Sinantan",
            "Sinidman Occidental",
            "Sinidman Oriental",
            "Suarez (Manlangit)",
            "Sugod (Pob.)",
            "Tabawan",
            "Takut",
            "Talahiban",
            "Talahid",
            "Tanval",
            "Tapa-e",
            "Tarabucan",
            "Tigbe",
            "Tinambacan Norte",
            "Tinambacan Sur",
            "Tinaplacan",
            "Tomaliguez",
            "Tonga-tonga",
            "Trinidad",
            "Trinidad (Sabang)",
            "Veloso",
            "Victory",
            "Villahermosa",
            "Villahermosa",
            "Others"});
            this.ComboBoxBrgy.Location = new System.Drawing.Point(114, 240);
            this.ComboBoxBrgy.Name = "ComboBoxBrgy";
            this.ComboBoxBrgy.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxBrgy.TabIndex = 8;
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.ComboBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "City", true));
            this.ComboBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource, "City", true));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "Almagro",
            "Calbayog City",
            "Gandara",
            "San Jorge",
            "Sta. Margarita",
            "Sto. Nino",
            "Tagapul-an",
            "Tarangnan",
            "Allen",
            "Catarman",
            "Catbalogan",
            "Others"});
            this.ComboBoxCity.Location = new System.Drawing.Point(114, 213);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxCity.TabIndex = 7;
            // 
            // metroTextBoxMother
            // 
            // 
            // 
            // 
            this.metroTextBoxMother.CustomButton.Image = null;
            this.metroTextBoxMother.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxMother.CustomButton.Name = "";
            this.metroTextBoxMother.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMother.CustomButton.TabIndex = 1;
            this.metroTextBoxMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMother.CustomButton.UseSelectable = true;
            this.metroTextBoxMother.CustomButton.Visible = false;
            this.metroTextBoxMother.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Mother", true));
            this.metroTextBoxMother.Lines = new string[0];
            this.metroTextBoxMother.Location = new System.Drawing.Point(114, 352);
            this.metroTextBoxMother.MaxLength = 32767;
            this.metroTextBoxMother.Name = "metroTextBoxMother";
            this.metroTextBoxMother.PasswordChar = '\0';
            this.metroTextBoxMother.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMother.SelectedText = "";
            this.metroTextBoxMother.SelectionLength = 0;
            this.metroTextBoxMother.SelectionStart = 0;
            this.metroTextBoxMother.ShortcutsEnabled = true;
            this.metroTextBoxMother.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxMother.TabIndex = 12;
            this.metroTextBoxMother.UseSelectable = true;
            this.metroTextBoxMother.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMother.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxFather
            // 
            // 
            // 
            // 
            this.metroTextBoxFather.CustomButton.Image = null;
            this.metroTextBoxFather.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxFather.CustomButton.Name = "";
            this.metroTextBoxFather.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFather.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFather.CustomButton.TabIndex = 1;
            this.metroTextBoxFather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFather.CustomButton.UseSelectable = true;
            this.metroTextBoxFather.CustomButton.Visible = false;
            this.metroTextBoxFather.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Father", true));
            this.metroTextBoxFather.Lines = new string[0];
            this.metroTextBoxFather.Location = new System.Drawing.Point(114, 321);
            this.metroTextBoxFather.MaxLength = 32767;
            this.metroTextBoxFather.Name = "metroTextBoxFather";
            this.metroTextBoxFather.PasswordChar = '\0';
            this.metroTextBoxFather.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFather.SelectedText = "";
            this.metroTextBoxFather.SelectionLength = 0;
            this.metroTextBoxFather.SelectionStart = 0;
            this.metroTextBoxFather.ShortcutsEnabled = true;
            this.metroTextBoxFather.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxFather.TabIndex = 11;
            this.metroTextBoxFather.UseSelectable = true;
            this.metroTextBoxFather.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFather.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(8, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Mother";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(8, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Father";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(6, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Civil Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(8, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Ivory;
            this.label11.Location = new System.Drawing.Point(8, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Ivory;
            this.label12.Location = new System.Drawing.Point(6, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Barangay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Ivory;
            this.label13.Location = new System.Drawing.Point(8, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Ivory;
            this.label14.Location = new System.Drawing.Point(6, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "Lastname";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Ivory;
            this.label15.Location = new System.Drawing.Point(6, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Middlename";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Ivory;
            this.label16.Location = new System.Drawing.Point(8, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "Firstname";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Ivory;
            this.label17.Location = new System.Drawing.Point(8, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Hospital No.";
            // 
            // panelNew
            // 
            this.panelNew.BackColor = System.Drawing.Color.ForestGreen;
            this.panelNew.Controls.Add(this.metroTextBoxAge);
            this.panelNew.Controls.Add(this.DateTimeBday);
            this.panelNew.Controls.Add(this.TextBoxLstnm);
            this.panelNew.Controls.Add(this.bunifuFlatButtonSave);
            this.panelNew.Controls.Add(this.TextBoxHosNo);
            this.panelNew.Controls.Add(this.bunifuFlatButtonClear);
            this.panelNew.Controls.Add(this.TextBoxMdnm);
            this.panelNew.Controls.Add(this.label17);
            this.panelNew.Controls.Add(this.TextBoxFrstnm);
            this.panelNew.Controls.Add(this.label16);
            this.panelNew.Controls.Add(this.label15);
            this.panelNew.Controls.Add(this.label14);
            this.panelNew.Controls.Add(this.label13);
            this.panelNew.Controls.Add(this.label12);
            this.panelNew.Controls.Add(this.label11);
            this.panelNew.Controls.Add(this.label9);
            this.panelNew.Controls.Add(this.TextBoxBplace);
            this.panelNew.Controls.Add(this.label8);
            this.panelNew.Controls.Add(this.label4);
            this.panelNew.Controls.Add(this.label7);
            this.panelNew.Controls.Add(this.comboBoxStatus);
            this.panelNew.Controls.Add(this.label6);
            this.panelNew.Controls.Add(this.comboBoxGender);
            this.panelNew.Controls.Add(this.label5);
            this.panelNew.Controls.Add(this.ComboBoxBrgy);
            this.panelNew.Controls.Add(this.metroTextBoxFather);
            this.panelNew.Controls.Add(this.ComboBoxCity);
            this.panelNew.Controls.Add(this.metroTextBoxMother);
            this.panelNew.Enabled = false;
            this.panelNew.Location = new System.Drawing.Point(0, 0);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(262, 447);
            this.panelNew.TabIndex = 4;
            // 
            // metroTextBoxAge
            // 
            // 
            // 
            // 
            this.metroTextBoxAge.CustomButton.Image = null;
            this.metroTextBoxAge.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.metroTextBoxAge.CustomButton.Name = "";
            this.metroTextBoxAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAge.CustomButton.TabIndex = 1;
            this.metroTextBoxAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAge.CustomButton.UseSelectable = true;
            this.metroTextBoxAge.CustomButton.Visible = false;
            this.metroTextBoxAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Age", true));
            this.metroTextBoxAge.Lines = new string[0];
            this.metroTextBoxAge.Location = new System.Drawing.Point(114, 154);
            this.metroTextBoxAge.MaxLength = 32767;
            this.metroTextBoxAge.Name = "metroTextBoxAge";
            this.metroTextBoxAge.PasswordChar = '\0';
            this.metroTextBoxAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAge.SelectedText = "";
            this.metroTextBoxAge.SelectionLength = 0;
            this.metroTextBoxAge.SelectionStart = 0;
            this.metroTextBoxAge.ShortcutsEnabled = true;
            this.metroTextBoxAge.Size = new System.Drawing.Size(60, 23);
            this.metroTextBoxAge.TabIndex = 5;
            this.metroTextBoxAge.UseSelectable = true;
            this.metroTextBoxAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DateTimeBday
            // 
            this.DateTimeBday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Birthday", true));
            this.DateTimeBday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Birthday", true));
            this.DateTimeBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeBday.Location = new System.Drawing.Point(114, 125);
            this.DateTimeBday.Name = "DateTimeBday";
            this.DateTimeBday.Size = new System.Drawing.Size(140, 20);
            this.DateTimeBday.TabIndex = 4;
            this.DateTimeBday.ValueChanged += new System.EventHandler(this.DateTimeBday_ValueChanged);
            // 
            // LinkNew
            // 
            this.LinkNew.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.LinkNew.AutoSize = true;
            this.LinkNew.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNew.LinkColor = System.Drawing.Color.DarkGreen;
            this.LinkNew.Location = new System.Drawing.Point(268, 414);
            this.LinkNew.Name = "LinkNew";
            this.LinkNew.Size = new System.Drawing.Size(75, 18);
            this.LinkNew.TabIndex = 0;
            this.LinkNew.TabStop = true;
            this.LinkNew.Text = "Add New";
            this.LinkNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNew_LinkClicked);
            // 
            // LinkEdit
            // 
            this.LinkEdit.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.LinkEdit.AutoSize = true;
            this.LinkEdit.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkEdit.LinkColor = System.Drawing.Color.DarkGreen;
            this.LinkEdit.Location = new System.Drawing.Point(360, 414);
            this.LinkEdit.Name = "LinkEdit";
            this.LinkEdit.Size = new System.Drawing.Size(40, 18);
            this.LinkEdit.TabIndex = 1;
            this.LinkEdit.TabStop = true;
            this.LinkEdit.Text = "Edit";
            this.LinkEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEdit_LinkClicked);
            // 
            // TxtboxSearch
            // 
            // 
            // 
            // 
            this.TxtboxSearch.CustomButton.Image = null;
            this.TxtboxSearch.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.TxtboxSearch.CustomButton.Name = "";
            this.TxtboxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtboxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtboxSearch.CustomButton.TabIndex = 1;
            this.TxtboxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtboxSearch.CustomButton.UseSelectable = true;
            this.TxtboxSearch.CustomButton.Visible = false;
            this.TxtboxSearch.Lines = new string[0];
            this.TxtboxSearch.Location = new System.Drawing.Point(322, 54);
            this.TxtboxSearch.MaxLength = 32767;
            this.TxtboxSearch.Name = "TxtboxSearch";
            this.TxtboxSearch.PasswordChar = '\0';
            this.TxtboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtboxSearch.SelectedText = "";
            this.TxtboxSearch.SelectionLength = 0;
            this.TxtboxSearch.SelectionStart = 0;
            this.TxtboxSearch.ShortcutsEnabled = true;
            this.TxtboxSearch.Size = new System.Drawing.Size(174, 23);
            this.TxtboxSearch.TabIndex = 8;
            this.TxtboxSearch.UseSelectable = true;
            this.TxtboxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtboxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtboxSearch.Click += new System.EventHandler(this.TxtboxSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(268, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Search";
            // 
            // bunifuCustomDataGridProfile
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGridProfile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGridProfile.AutoGenerateColumns = false;
            this.bunifuCustomDataGridProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGridProfile.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGridProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGridProfile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGridProfile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGridProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGridProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.bunifuCustomDataGridProfile.DataSource = this.patientBindingSource;
            this.bunifuCustomDataGridProfile.DoubleBuffered = true;
            this.bunifuCustomDataGridProfile.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGridProfile.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGridProfile.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomDataGridProfile.Location = new System.Drawing.Point(265, 84);
            this.bunifuCustomDataGridProfile.Name = "bunifuCustomDataGridProfile";
            this.bunifuCustomDataGridProfile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGridProfile.Size = new System.Drawing.Size(740, 316);
            this.bunifuCustomDataGridProfile.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(515, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Patients Profile List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CDHPRIMS.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(931, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HospitalNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "HospitalNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Midname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Midname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn5.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn6.HeaderText = "Age";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Birthplace";
            this.dataGridViewTextBoxColumn7.HeaderText = "Birthplace";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn8.HeaderText = "City";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Barangay";
            this.dataGridViewTextBoxColumn9.HeaderText = "Barangay";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn10.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn11.HeaderText = "Status";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Father";
            this.dataGridViewTextBoxColumn12.HeaderText = "Father";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Mother";
            this.dataGridViewTextBoxColumn13.HeaderText = "Mother";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(CDHPRIMS.Patient);
            // 
            // bunifuFlatButtonSave
            // 
            this.bunifuFlatButtonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSave.BorderRadius = 0;
            this.bunifuFlatButtonSave.ButtonText = "Save";
            this.bunifuFlatButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonSave.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonSave.Iconimage")));
            this.bunifuFlatButtonSave.Iconimage_right = null;
            this.bunifuFlatButtonSave.Iconimage_right_Selected = null;
            this.bunifuFlatButtonSave.Iconimage_Selected = null;
            this.bunifuFlatButtonSave.IconMarginLeft = 0;
            this.bunifuFlatButtonSave.IconMarginRight = 0;
            this.bunifuFlatButtonSave.IconRightVisible = true;
            this.bunifuFlatButtonSave.IconRightZoom = 0D;
            this.bunifuFlatButtonSave.IconVisible = true;
            this.bunifuFlatButtonSave.IconZoom = 90D;
            this.bunifuFlatButtonSave.IsTab = false;
            this.bunifuFlatButtonSave.Location = new System.Drawing.Point(157, 397);
            this.bunifuFlatButtonSave.Name = "bunifuFlatButtonSave";
            this.bunifuFlatButtonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButtonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSave.selected = false;
            this.bunifuFlatButtonSave.Size = new System.Drawing.Size(97, 35);
            this.bunifuFlatButtonSave.TabIndex = 13;
            this.bunifuFlatButtonSave.Text = "Save";
            this.bunifuFlatButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonSave.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonSave.Click += new System.EventHandler(this.bunifuFlatButtonSave_Click);
            // 
            // bunifuFlatButtonClear
            // 
            this.bunifuFlatButtonClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonClear.BorderRadius = 0;
            this.bunifuFlatButtonClear.ButtonText = "Clear";
            this.bunifuFlatButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonClear.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonClear.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonClear.Iconimage")));
            this.bunifuFlatButtonClear.Iconimage_right = null;
            this.bunifuFlatButtonClear.Iconimage_right_Selected = null;
            this.bunifuFlatButtonClear.Iconimage_Selected = null;
            this.bunifuFlatButtonClear.IconMarginLeft = 0;
            this.bunifuFlatButtonClear.IconMarginRight = 0;
            this.bunifuFlatButtonClear.IconRightVisible = true;
            this.bunifuFlatButtonClear.IconRightZoom = 0D;
            this.bunifuFlatButtonClear.IconVisible = true;
            this.bunifuFlatButtonClear.IconZoom = 90D;
            this.bunifuFlatButtonClear.IsTab = false;
            this.bunifuFlatButtonClear.Location = new System.Drawing.Point(11, 397);
            this.bunifuFlatButtonClear.Name = "bunifuFlatButtonClear";
            this.bunifuFlatButtonClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButtonClear.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonClear.selected = false;
            this.bunifuFlatButtonClear.Size = new System.Drawing.Size(97, 35);
            this.bunifuFlatButtonClear.TabIndex = 14;
            this.bunifuFlatButtonClear.Text = "Clear";
            this.bunifuFlatButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonClear.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UserControlPatientPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCustomDataGridProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxSearch);
            this.Controls.Add(this.LinkEdit);
            this.Controls.Add(this.LinkNew);
            this.Controls.Add(this.panelNew);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserControlPatientPro";
            this.Size = new System.Drawing.Size(1009, 447);
            this.Load += new System.EventHandler(this.UserControlPatientPro_Load);
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxLstnm;
        private System.Windows.Forms.TextBox TextBoxMdnm;
        private System.Windows.Forms.TextBox TextBoxFrstnm;
        private System.Windows.Forms.TextBox TextBoxHosNo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSave;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonClear;
        private MetroFramework.Controls.MetroTextBox TextBoxBplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox ComboBoxBrgy;
        private System.Windows.Forms.ComboBox ComboBoxCity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMother;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFather;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.LinkLabel LinkNew;
        private System.Windows.Forms.LinkLabel LinkEdit;
        private MetroFramework.Controls.MetroTextBox TxtboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimeBday;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAge;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGridProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
