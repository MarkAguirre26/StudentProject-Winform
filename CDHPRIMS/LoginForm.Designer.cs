namespace CDHPRIMS
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTextBoxPword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxUtype = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroButtonCreate = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxPword
            // 
            // 
            // 
            // 
            this.metroTextBoxPword.CustomButton.Image = null;
            this.metroTextBoxPword.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.metroTextBoxPword.CustomButton.Name = "";
            this.metroTextBoxPword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPword.CustomButton.TabIndex = 1;
            this.metroTextBoxPword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPword.CustomButton.UseSelectable = true;
            this.metroTextBoxPword.CustomButton.Visible = false;
            this.metroTextBoxPword.Lines = new string[0];
            this.metroTextBoxPword.Location = new System.Drawing.Point(182, 147);
            this.metroTextBoxPword.MaxLength = 32767;
            this.metroTextBoxPword.Name = "metroTextBoxPword";
            this.metroTextBoxPword.PasswordChar = '*';
            this.metroTextBoxPword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPword.SelectedText = "";
            this.metroTextBoxPword.SelectionLength = 0;
            this.metroTextBoxPword.SelectionStart = 0;
            this.metroTextBoxPword.ShortcutsEnabled = true;
            this.metroTextBoxPword.Size = new System.Drawing.Size(170, 23);
            this.metroTextBoxPword.TabIndex = 10;
            this.metroTextBoxPword.UseSelectable = true;
            this.metroTextBoxPword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxUsername
            // 
            // 
            // 
            // 
            this.metroTextBoxUsername.CustomButton.Image = null;
            this.metroTextBoxUsername.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.metroTextBoxUsername.CustomButton.Name = "";
            this.metroTextBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxUsername.CustomButton.Visible = false;
            this.metroTextBoxUsername.Lines = new string[0];
            this.metroTextBoxUsername.Location = new System.Drawing.Point(182, 110);
            this.metroTextBoxUsername.MaxLength = 32767;
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.PasswordChar = '\0';
            this.metroTextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsername.SelectedText = "";
            this.metroTextBoxUsername.SelectionLength = 0;
            this.metroTextBoxUsername.SelectionStart = 0;
            this.metroTextBoxUsername.ShortcutsEnabled = true;
            this.metroTextBoxUsername.Size = new System.Drawing.Size(170, 23);
            this.metroTextBoxUsername.TabIndex = 9;
            this.metroTextBoxUsername.UseSelectable = true;
            this.metroTextBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxUtype
            // 
            this.comboBoxUtype.FormattingEnabled = true;
            this.comboBoxUtype.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.comboBoxUtype.Location = new System.Drawing.Point(183, 75);
            this.comboBoxUtype.Name = "comboBoxUtype";
            this.comboBoxUtype.Size = new System.Drawing.Size(169, 21);
            this.comboBoxUtype.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 89);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // metroButtonCreate
            // 
            this.metroButtonCreate.Location = new System.Drawing.Point(182, 190);
            this.metroButtonCreate.Name = "metroButtonCreate";
            this.metroButtonCreate.Size = new System.Drawing.Size(75, 41);
            this.metroButtonCreate.TabIndex = 14;
            this.metroButtonCreate.Text = "Create User";
            this.metroButtonCreate.UseSelectable = true;
            this.metroButtonCreate.Click += new System.EventHandler(this.metroButtonCreate_Click);
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(277, 190);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(75, 41);
            this.metroButtonLogin.TabIndex = 15;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.metroButtonCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTextBoxPword);
            this.Controls.Add(this.metroTextBoxUsername);
            this.Controls.Add(this.comboBoxUtype);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxPword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private System.Windows.Forms.ComboBox comboBoxUtype;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton metroButtonCreate;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private System.Windows.Forms.Button button1;
    }
}

