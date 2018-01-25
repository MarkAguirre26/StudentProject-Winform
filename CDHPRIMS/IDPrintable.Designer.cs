namespace CDHPRIMS
{
    partial class IDPrintable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDPrintable));
            this.reportViewerID = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // reportViewerID
            // 
            this.reportViewerID.LocalReport.ReportEmbeddedResource = "CDHPRIMS.ReportID.rdlc";
            this.reportViewerID.Location = new System.Drawing.Point(10, 116);
            this.reportViewerID.Name = "reportViewerID";
            this.reportViewerID.ServerReport.BearerToken = null;
            this.reportViewerID.Size = new System.Drawing.Size(452, 363);
            this.reportViewerID.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Search";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(361, 79);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(91, 31);
            this.bunifuFlatButton1.TabIndex = 45;
            this.bunifuFlatButton1.Text = "Search";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Search";
            // 
            // TxtboxSearch
            // 
            // 
            // 
            // 
            this.TxtboxSearch.CustomButton.Image = null;
            this.TxtboxSearch.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.TxtboxSearch.CustomButton.Name = "";
            this.TxtboxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtboxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtboxSearch.CustomButton.TabIndex = 1;
            this.TxtboxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtboxSearch.CustomButton.UseSelectable = true;
            this.TxtboxSearch.CustomButton.Visible = false;
            this.TxtboxSearch.Lines = new string[0];
            this.TxtboxSearch.Location = new System.Drawing.Point(76, 87);
            this.TxtboxSearch.MaxLength = 32767;
            this.TxtboxSearch.Name = "TxtboxSearch";
            this.TxtboxSearch.PasswordChar = '\0';
            this.TxtboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtboxSearch.SelectedText = "";
            this.TxtboxSearch.SelectionLength = 0;
            this.TxtboxSearch.SelectionStart = 0;
            this.TxtboxSearch.ShortcutsEnabled = true;
            this.TxtboxSearch.Size = new System.Drawing.Size(279, 23);
            this.TxtboxSearch.TabIndex = 43;
            this.TxtboxSearch.UseSelectable = true;
            this.TxtboxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtboxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IDPrintable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 502);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxSearch);
            this.Controls.Add(this.reportViewerID);
            this.Name = "IDPrintable";
            this.Load += new System.EventHandler(this.IDPrintable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerID;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox TxtboxSearch;
    }
}