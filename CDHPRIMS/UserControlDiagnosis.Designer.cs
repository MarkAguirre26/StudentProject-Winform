namespace CDHPRIMS
{
    partial class UserControlDiagnosis
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
            this.metroTextBoxPhysician = new MetroFramework.Controls.MetroTextBox();
            this.bunifuFlatButtonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxResults = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBoxDisposition = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButtonclr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBoxDiagnosNo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelDisposition = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.richTextBoxPrinDiagnosis = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAdminDiagnosis = new System.Windows.Forms.RichTextBox();
            this.textBoxhospnum = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.dateTimePickerDischarge = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAdmitted = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.richTextBoxPrinProcedure = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ComboBoxAdmisionType = new System.Windows.Forms.ComboBox();
            this.LinkEdit = new System.Windows.Forms.LinkLabel();
            this.LinkNew = new System.Windows.Forms.LinkLabel();
            this.LabelHistory = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridViewDiagnos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.diagnosisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDischargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionDiagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principalDiagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinProceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnoseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnoseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxPhysician
            // 
            // 
            // 
            // 
            this.metroTextBoxPhysician.CustomButton.Image = null;
            this.metroTextBoxPhysician.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.metroTextBoxPhysician.CustomButton.Name = "";
            this.metroTextBoxPhysician.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPhysician.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPhysician.CustomButton.TabIndex = 1;
            this.metroTextBoxPhysician.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPhysician.CustomButton.UseSelectable = true;
            this.metroTextBoxPhysician.CustomButton.Visible = false;
            this.metroTextBoxPhysician.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "Physician", true));
            this.metroTextBoxPhysician.Lines = new string[0];
            this.metroTextBoxPhysician.Location = new System.Drawing.Point(149, 141);
            this.metroTextBoxPhysician.MaxLength = 32767;
            this.metroTextBoxPhysician.Name = "metroTextBoxPhysician";
            this.metroTextBoxPhysician.PasswordChar = '\0';
            this.metroTextBoxPhysician.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPhysician.SelectedText = "";
            this.metroTextBoxPhysician.SelectionLength = 0;
            this.metroTextBoxPhysician.SelectionStart = 0;
            this.metroTextBoxPhysician.ShortcutsEnabled = true;
            this.metroTextBoxPhysician.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxPhysician.TabIndex = 4;
            this.metroTextBoxPhysician.UseSelectable = true;
            this.metroTextBoxPhysician.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPhysician.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bunifuFlatButtonSave
            // 
            this.bunifuFlatButtonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSave.BorderRadius = 0;
            this.bunifuFlatButtonSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButtonSave.ButtonText = "Save";
            this.bunifuFlatButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonSave.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSave.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSave.Iconimage = null;
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
            this.bunifuFlatButtonSave.Location = new System.Drawing.Point(149, 383);
            this.bunifuFlatButtonSave.Name = "bunifuFlatButtonSave";
            this.bunifuFlatButtonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButtonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSave.selected = false;
            this.bunifuFlatButtonSave.Size = new System.Drawing.Size(76, 41);
            this.bunifuFlatButtonSave.TabIndex = 9;
            this.bunifuFlatButtonSave.Text = "Save";
            this.bunifuFlatButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonSave.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonSave.Click += new System.EventHandler(this.bunifuFlatButtonSave_Click);
            // 
            // comboBoxResults
            // 
            this.comboBoxResults.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "Results", true));
            this.comboBoxResults.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diagnoseBindingSource, "Results", true));
            this.comboBoxResults.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.diagnoseBindingSource, "Results", true));
            this.comboBoxResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResults.FormattingEnabled = true;
            this.comboBoxResults.Items.AddRange(new object[] {
            "Recovered",
            "Died",
            "Improved",
            "Unimproved",
            "Autopsy",
            "No Autopsy"});
            this.comboBoxResults.Location = new System.Drawing.Point(149, 333);
            this.comboBoxResults.Name = "comboBoxResults";
            this.comboBoxResults.Size = new System.Drawing.Size(178, 21);
            this.comboBoxResults.TabIndex = 8;
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(60, 38);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(83, 18);
            this.bunifuCustomLabel19.TabIndex = 63;
            this.bunifuCustomLabel19.Text = "Hospital No.";
            // 
            // comboBoxDisposition
            // 
            this.comboBoxDisposition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "Disposition", true));
            this.comboBoxDisposition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diagnoseBindingSource, "Disposition", true));
            this.comboBoxDisposition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.diagnoseBindingSource, "Disposition", true));
            this.comboBoxDisposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisposition.FormattingEnabled = true;
            this.comboBoxDisposition.Items.AddRange(new object[] {
            "Discharge",
            "Transferred",
            "Hama",
            "Absconded"});
            this.comboBoxDisposition.Location = new System.Drawing.Point(149, 306);
            this.comboBoxDisposition.Name = "comboBoxDisposition";
            this.comboBoxDisposition.Size = new System.Drawing.Size(178, 21);
            this.comboBoxDisposition.TabIndex = 7;
            // 
            // bunifuFlatButtonclr
            // 
            this.bunifuFlatButtonclr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonclr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonclr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonclr.BorderRadius = 0;
            this.bunifuFlatButtonclr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButtonclr.ButtonText = "Clear";
            this.bunifuFlatButtonclr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonclr.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonclr.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonclr.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonclr.Iconimage = null;
            this.bunifuFlatButtonclr.Iconimage_right = null;
            this.bunifuFlatButtonclr.Iconimage_right_Selected = null;
            this.bunifuFlatButtonclr.Iconimage_Selected = null;
            this.bunifuFlatButtonclr.IconMarginLeft = 0;
            this.bunifuFlatButtonclr.IconMarginRight = 0;
            this.bunifuFlatButtonclr.IconRightVisible = true;
            this.bunifuFlatButtonclr.IconRightZoom = 0D;
            this.bunifuFlatButtonclr.IconVisible = true;
            this.bunifuFlatButtonclr.IconZoom = 90D;
            this.bunifuFlatButtonclr.IsTab = false;
            this.bunifuFlatButtonclr.Location = new System.Drawing.Point(239, 383);
            this.bunifuFlatButtonclr.Name = "bunifuFlatButtonclr";
            this.bunifuFlatButtonclr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonclr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButtonclr.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonclr.selected = false;
            this.bunifuFlatButtonclr.Size = new System.Drawing.Size(76, 41);
            this.bunifuFlatButtonclr.TabIndex = 11;
            this.bunifuFlatButtonclr.Text = "Clear";
            this.bunifuFlatButtonclr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonclr.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonclr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textBoxDiagnosNo
            // 
            this.textBoxDiagnosNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "DiagnosisNo", true));
            this.textBoxDiagnosNo.Location = new System.Drawing.Point(149, 10);
            this.textBoxDiagnosNo.Name = "textBoxDiagnosNo";
            this.textBoxDiagnosNo.Size = new System.Drawing.Size(178, 20);
            this.textBoxDiagnosNo.TabIndex = 0;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(48, 12);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(95, 18);
            this.bunifuCustomLabel5.TabIndex = 49;
            this.bunifuCustomLabel5.Text = "Diagnosis No.:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(91, 336);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 18);
            this.bunifuCustomLabel1.TabIndex = 45;
            this.bunifuCustomLabel1.Text = "Results";
            // 
            // bunifuCustomLabelDisposition
            // 
            this.bunifuCustomLabelDisposition.AutoSize = true;
            this.bunifuCustomLabelDisposition.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelDisposition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabelDisposition.Location = new System.Drawing.Point(66, 309);
            this.bunifuCustomLabelDisposition.Name = "bunifuCustomLabelDisposition";
            this.bunifuCustomLabelDisposition.Size = new System.Drawing.Size(77, 18);
            this.bunifuCustomLabelDisposition.TabIndex = 44;
            this.bunifuCustomLabelDisposition.Text = "Disposition";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 216);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(125, 18);
            this.bunifuCustomLabel2.TabIndex = 46;
            this.bunifuCustomLabel2.Text = "Principal Diagnosis";
            // 
            // richTextBoxPrinDiagnosis
            // 
            this.richTextBoxPrinDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "PrincipalDiagnosis", true));
            this.richTextBoxPrinDiagnosis.Location = new System.Drawing.Point(149, 216);
            this.richTextBoxPrinDiagnosis.Name = "richTextBoxPrinDiagnosis";
            this.richTextBoxPrinDiagnosis.Size = new System.Drawing.Size(178, 39);
            this.richTextBoxPrinDiagnosis.TabIndex = 6;
            this.richTextBoxPrinDiagnosis.Text = "";
            // 
            // richTextBoxAdminDiagnosis
            // 
            this.richTextBoxAdminDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "AdmissionDiagnosis", true));
            this.richTextBoxAdminDiagnosis.Location = new System.Drawing.Point(149, 170);
            this.richTextBoxAdminDiagnosis.Name = "richTextBoxAdminDiagnosis";
            this.richTextBoxAdminDiagnosis.Size = new System.Drawing.Size(178, 40);
            this.richTextBoxAdminDiagnosis.TabIndex = 5;
            this.richTextBoxAdminDiagnosis.Text = "";
            // 
            // textBoxhospnum
            // 
            this.textBoxhospnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "HospitalNo", true));
            this.textBoxhospnum.Location = new System.Drawing.Point(149, 36);
            this.textBoxhospnum.Name = "textBoxhospnum";
            this.textBoxhospnum.Size = new System.Drawing.Size(178, 20);
            this.textBoxhospnum.TabIndex = 1;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(7, 170);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(136, 18);
            this.bunifuCustomLabel3.TabIndex = 47;
            this.bunifuCustomLabel3.Text = "Admission Diagnosis";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(14, 146);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(129, 18);
            this.bunifuCustomLabel6.TabIndex = 50;
            this.bunifuCustomLabel6.Text = "Attending Physician";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.panelAdd.Controls.Add(this.dateTimePickerDischarge);
            this.panelAdd.Controls.Add(this.dateTimePickerAdmitted);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel12);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel11);
            this.panelAdd.Controls.Add(this.richTextBoxPrinProcedure);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel7);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel4);
            this.panelAdd.Controls.Add(this.ComboBoxAdmisionType);
            this.panelAdd.Controls.Add(this.bunifuFlatButtonSave);
            this.panelAdd.Controls.Add(this.textBoxDiagnosNo);
            this.panelAdd.Controls.Add(this.bunifuFlatButtonclr);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel6);
            this.panelAdd.Controls.Add(this.metroTextBoxPhysician);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel3);
            this.panelAdd.Controls.Add(this.textBoxhospnum);
            this.panelAdd.Controls.Add(this.richTextBoxAdminDiagnosis);
            this.panelAdd.Controls.Add(this.comboBoxResults);
            this.panelAdd.Controls.Add(this.richTextBoxPrinDiagnosis);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel19);
            this.panelAdd.Controls.Add(this.comboBoxDisposition);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel2);
            this.panelAdd.Controls.Add(this.bunifuCustomLabelDisposition);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel1);
            this.panelAdd.Controls.Add(this.bunifuCustomLabel5);
            this.panelAdd.Enabled = false;
            this.panelAdd.Location = new System.Drawing.Point(675, 0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(331, 447);
            this.panelAdd.TabIndex = 69;
            // 
            // dateTimePickerDischarge
            // 
            this.dateTimePickerDischarge.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diagnoseBindingSource, "DateDischarge", true));
            this.dateTimePickerDischarge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "DateDischarge", true));
            this.dateTimePickerDischarge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDischarge.Location = new System.Drawing.Point(149, 88);
            this.dateTimePickerDischarge.Name = "dateTimePickerDischarge";
            this.dateTimePickerDischarge.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerDischarge.TabIndex = 78;
            // 
            // dateTimePickerAdmitted
            // 
            this.dateTimePickerAdmitted.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diagnoseBindingSource, "DateAdmitted", true));
            this.dateTimePickerAdmitted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "DateAdmitted", true));
            this.dateTimePickerAdmitted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdmitted.Location = new System.Drawing.Point(149, 62);
            this.dateTimePickerAdmitted.Name = "dateTimePickerAdmitted";
            this.dateTimePickerAdmitted.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerAdmitted.TabIndex = 77;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(45, 91);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(98, 18);
            this.bunifuCustomLabel12.TabIndex = 76;
            this.bunifuCustomLabel12.Text = "DateDischarge";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(49, 65);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(94, 18);
            this.bunifuCustomLabel11.TabIndex = 75;
            this.bunifuCustomLabel11.Text = "DateAdmitted";
            // 
            // richTextBoxPrinProcedure
            // 
            this.richTextBoxPrinProcedure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "PrinProce", true));
            this.richTextBoxPrinProcedure.Location = new System.Drawing.Point(149, 261);
            this.richTextBoxPrinProcedure.Name = "richTextBoxPrinProcedure";
            this.richTextBoxPrinProcedure.Size = new System.Drawing.Size(178, 39);
            this.richTextBoxPrinProcedure.TabIndex = 69;
            this.richTextBoxPrinProcedure.Text = "";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(17, 261);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(126, 18);
            this.bunifuCustomLabel7.TabIndex = 70;
            this.bunifuCustomLabel7.Text = "Principal Procedure";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(36, 117);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(107, 18);
            this.bunifuCustomLabel4.TabIndex = 68;
            this.bunifuCustomLabel4.Text = "Admission Type";
            // 
            // ComboBoxAdmisionType
            // 
            this.ComboBoxAdmisionType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnoseBindingSource, "AdmissionType", true));
            this.ComboBoxAdmisionType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diagnoseBindingSource, "AdmissionType", true));
            this.ComboBoxAdmisionType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.diagnoseBindingSource, "AdmissionType", true));
            this.ComboBoxAdmisionType.FormattingEnabled = true;
            this.ComboBoxAdmisionType.Items.AddRange(new object[] {
            "New",
            "Old",
            "Former OPD"});
            this.ComboBoxAdmisionType.Location = new System.Drawing.Point(149, 114);
            this.ComboBoxAdmisionType.Name = "ComboBoxAdmisionType";
            this.ComboBoxAdmisionType.Size = new System.Drawing.Size(178, 21);
            this.ComboBoxAdmisionType.TabIndex = 67;
            // 
            // LinkEdit
            // 
            this.LinkEdit.AutoSize = true;
            this.LinkEdit.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkEdit.LinkColor = System.Drawing.Color.DarkGreen;
            this.LinkEdit.Location = new System.Drawing.Point(625, 415);
            this.LinkEdit.Name = "LinkEdit";
            this.LinkEdit.Size = new System.Drawing.Size(40, 18);
            this.LinkEdit.TabIndex = 72;
            this.LinkEdit.TabStop = true;
            this.LinkEdit.Text = "Edit";
            this.LinkEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEdit_LinkClicked);
            // 
            // LinkNew
            // 
            this.LinkNew.AutoSize = true;
            this.LinkNew.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNew.LinkColor = System.Drawing.Color.DarkGreen;
            this.LinkNew.Location = new System.Drawing.Point(532, 415);
            this.LinkNew.Name = "LinkNew";
            this.LinkNew.Size = new System.Drawing.Size(75, 18);
            this.LinkNew.TabIndex = 71;
            this.LinkNew.TabStop = true;
            this.LinkNew.Text = "Add New";
            this.LinkNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNew_LinkClicked);
            // 
            // LabelHistory
            // 
            this.LabelHistory.AutoSize = true;
            this.LabelHistory.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistory.LinkColor = System.Drawing.Color.DarkGreen;
            this.LabelHistory.Location = new System.Drawing.Point(557, 86);
            this.LabelHistory.Name = "LabelHistory";
            this.LabelHistory.Size = new System.Drawing.Size(108, 18);
            this.LabelHistory.TabIndex = 73;
            this.LabelHistory.TabStop = true;
            this.LabelHistory.Text = "View History";
            this.LabelHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelHistory_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 74;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.DarkGreen;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(7, 86);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(52, 18);
            this.bunifuCustomLabel10.TabIndex = 75;
            this.bunifuCustomLabel10.Text = "Search:";
            // 
            // dataGridViewDiagnos
            // 
            this.dataGridViewDiagnos.AutoGenerateColumns = false;
            this.dataGridViewDiagnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiagnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiagnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagnosisNoDataGridViewTextBoxColumn,
            this.hospitalNoDataGridViewTextBoxColumn,
            this.dateAdmittedDataGridViewTextBoxColumn,
            this.dateDischargeDataGridViewTextBoxColumn,
            this.admissionTypeDataGridViewTextBoxColumn,
            this.physicianDataGridViewTextBoxColumn,
            this.admissionDiagnosisDataGridViewTextBoxColumn,
            this.principalDiagnosisDataGridViewTextBoxColumn,
            this.prinProceDataGridViewTextBoxColumn,
            this.dispositionDataGridViewTextBoxColumn,
            this.resultsDataGridViewTextBoxColumn});
            this.dataGridViewDiagnos.DataSource = this.diagnoseBindingSource;
            this.dataGridViewDiagnos.Location = new System.Drawing.Point(2, 119);
            this.dataGridViewDiagnos.Name = "dataGridViewDiagnos";
            this.dataGridViewDiagnos.Size = new System.Drawing.Size(669, 284);
            this.dataGridViewDiagnos.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(210, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 28);
            this.label2.TabIndex = 77;
            this.label2.Text = "Patients Diagnosis List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CDHPRIMS.Properties.Resources.diag;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // diagnosisNoDataGridViewTextBoxColumn
            // 
            this.diagnosisNoDataGridViewTextBoxColumn.DataPropertyName = "DiagnosisNo";
            this.diagnosisNoDataGridViewTextBoxColumn.HeaderText = "DiagnosisNo";
            this.diagnosisNoDataGridViewTextBoxColumn.Name = "diagnosisNoDataGridViewTextBoxColumn";
            // 
            // hospitalNoDataGridViewTextBoxColumn
            // 
            this.hospitalNoDataGridViewTextBoxColumn.DataPropertyName = "HospitalNo";
            this.hospitalNoDataGridViewTextBoxColumn.HeaderText = "HospitalNo";
            this.hospitalNoDataGridViewTextBoxColumn.Name = "hospitalNoDataGridViewTextBoxColumn";
            // 
            // dateAdmittedDataGridViewTextBoxColumn
            // 
            this.dateAdmittedDataGridViewTextBoxColumn.DataPropertyName = "DateAdmitted";
            this.dateAdmittedDataGridViewTextBoxColumn.HeaderText = "DateAdmitted";
            this.dateAdmittedDataGridViewTextBoxColumn.Name = "dateAdmittedDataGridViewTextBoxColumn";
            // 
            // dateDischargeDataGridViewTextBoxColumn
            // 
            this.dateDischargeDataGridViewTextBoxColumn.DataPropertyName = "DateDischarge";
            this.dateDischargeDataGridViewTextBoxColumn.HeaderText = "DateDischarge";
            this.dateDischargeDataGridViewTextBoxColumn.Name = "dateDischargeDataGridViewTextBoxColumn";
            // 
            // admissionTypeDataGridViewTextBoxColumn
            // 
            this.admissionTypeDataGridViewTextBoxColumn.DataPropertyName = "AdmissionType";
            this.admissionTypeDataGridViewTextBoxColumn.HeaderText = "AdmissionType";
            this.admissionTypeDataGridViewTextBoxColumn.Name = "admissionTypeDataGridViewTextBoxColumn";
            // 
            // physicianDataGridViewTextBoxColumn
            // 
            this.physicianDataGridViewTextBoxColumn.DataPropertyName = "Physician";
            this.physicianDataGridViewTextBoxColumn.HeaderText = "Physician";
            this.physicianDataGridViewTextBoxColumn.Name = "physicianDataGridViewTextBoxColumn";
            // 
            // admissionDiagnosisDataGridViewTextBoxColumn
            // 
            this.admissionDiagnosisDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDiagnosis";
            this.admissionDiagnosisDataGridViewTextBoxColumn.HeaderText = "AdmissionDiagnosis";
            this.admissionDiagnosisDataGridViewTextBoxColumn.Name = "admissionDiagnosisDataGridViewTextBoxColumn";
            // 
            // principalDiagnosisDataGridViewTextBoxColumn
            // 
            this.principalDiagnosisDataGridViewTextBoxColumn.DataPropertyName = "PrincipalDiagnosis";
            this.principalDiagnosisDataGridViewTextBoxColumn.HeaderText = "PrincipalDiagnosis";
            this.principalDiagnosisDataGridViewTextBoxColumn.Name = "principalDiagnosisDataGridViewTextBoxColumn";
            // 
            // prinProceDataGridViewTextBoxColumn
            // 
            this.prinProceDataGridViewTextBoxColumn.DataPropertyName = "PrinProce";
            this.prinProceDataGridViewTextBoxColumn.HeaderText = "PrinProce";
            this.prinProceDataGridViewTextBoxColumn.Name = "prinProceDataGridViewTextBoxColumn";
            // 
            // dispositionDataGridViewTextBoxColumn
            // 
            this.dispositionDataGridViewTextBoxColumn.DataPropertyName = "Disposition";
            this.dispositionDataGridViewTextBoxColumn.HeaderText = "Disposition";
            this.dispositionDataGridViewTextBoxColumn.Name = "dispositionDataGridViewTextBoxColumn";
            // 
            // resultsDataGridViewTextBoxColumn
            // 
            this.resultsDataGridViewTextBoxColumn.DataPropertyName = "Results";
            this.resultsDataGridViewTextBoxColumn.HeaderText = "Results";
            this.resultsDataGridViewTextBoxColumn.Name = "resultsDataGridViewTextBoxColumn";
            // 
            // diagnoseBindingSource
            // 
            this.diagnoseBindingSource.DataSource = typeof(CDHPRIMS.Diagnose);
            // 
            // UserControlDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDiagnos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.LabelHistory);
            this.Controls.Add(this.LinkEdit);
            this.Controls.Add(this.LinkNew);
            this.Controls.Add(this.panelAdd);
            this.Name = "UserControlDiagnosis";
            this.Size = new System.Drawing.Size(1009, 447);
            this.Load += new System.EventHandler(this.UserControlDiagnosis_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnoseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBoxPhysician;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSave;
        private System.Windows.Forms.ComboBox comboBoxResults;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private System.Windows.Forms.ComboBox comboBoxDisposition;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonclr;
        private System.Windows.Forms.TextBox textBoxDiagnosNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelDisposition;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.RichTextBox richTextBoxPrinDiagnosis;
        private System.Windows.Forms.RichTextBox richTextBoxAdminDiagnosis;
        public System.Windows.Forms.TextBox textBoxhospnum;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Panel panelAdd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox ComboBoxAdmisionType;
        private System.Windows.Forms.RichTextBox richTextBoxPrinProcedure;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.LinkLabel LinkEdit;
        private System.Windows.Forms.LinkLabel LinkNew;
        private System.Windows.Forms.LinkLabel LabelHistory;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.DateTimePicker dateTimePickerDischarge;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmitted;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinProcedureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewDiagnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisno;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateadmitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedischarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiontype;
        private System.Windows.Forms.DataGridViewTextBoxColumn physician;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiondiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn principaldiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinproce;
        private System.Windows.Forms.DataGridViewTextBoxColumn disposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn results;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdmittedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDischargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDiagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn principalDiagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinProceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diagnoseBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
