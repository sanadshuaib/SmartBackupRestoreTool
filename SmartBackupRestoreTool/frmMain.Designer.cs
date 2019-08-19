namespace SmartBackupRestoreTool
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpConnectionData = new Telerik.WinControls.UI.RadGroupBox();
            this.cboDatabase = new Telerik.WinControls.UI.RadDropDownList();
            this.cboServer = new Telerik.WinControls.UI.RadDropDownList();
            this.btnGetServers = new Telerik.WinControls.UI.RadButton();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.chkIntegratedSecurity = new Telerik.WinControls.UI.RadCheckBox();
            this.lblDatabase = new Telerik.WinControls.UI.RadLabel();
            this.lblPassword = new Telerik.WinControls.UI.RadLabel();
            this.lblUserName = new Telerik.WinControls.UI.RadLabel();
            this.lblServer = new Telerik.WinControls.UI.RadLabel();
            this.lblHeader = new Telerik.WinControls.UI.RadLabel();
            this.grpBackup = new Telerik.WinControls.UI.RadGroupBox();
            this.btnBackup = new Telerik.WinControls.UI.RadButton();
            this.chkDate = new Telerik.WinControls.UI.RadCheckBox();
            this.btnBrowse = new Telerik.WinControls.UI.RadButton();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtLocation = new Telerik.WinControls.UI.RadTextBox();
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.lblLocation = new Telerik.WinControls.UI.RadLabel();
            this.lblHeader2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PageView = new Telerik.WinControls.UI.RadPageView();
            this.BackupPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.RestorePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.grpRestore = new Telerik.WinControls.UI.RadGroupBox();
            this.btnRestore = new Telerik.WinControls.UI.RadButton();
            this.btnBrowseRestore = new Telerik.WinControls.UI.RadButton();
            this.txtRestoreLocation = new Telerik.WinControls.UI.RadTextBox();
            this.lblRestoreLocation = new Telerik.WinControls.UI.RadLabel();
            this.lblRestoreHeader = new Telerik.WinControls.UI.RadLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grpConnectionData)).BeginInit();
            this.grpConnectionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIntegratedSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBackup)).BeginInit();
            this.grpBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageView)).BeginInit();
            this.PageView.SuspendLayout();
            this.BackupPage.SuspendLayout();
            this.RestorePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRestore)).BeginInit();
            this.grpRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestoreLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRestoreLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRestoreHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConnectionData
            // 
            this.grpConnectionData.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grpConnectionData.Controls.Add(this.cboDatabase);
            this.grpConnectionData.Controls.Add(this.cboServer);
            this.grpConnectionData.Controls.Add(this.btnGetServers);
            this.grpConnectionData.Controls.Add(this.txtPassword);
            this.grpConnectionData.Controls.Add(this.txtUserName);
            this.grpConnectionData.Controls.Add(this.chkIntegratedSecurity);
            this.grpConnectionData.Controls.Add(this.lblDatabase);
            this.grpConnectionData.Controls.Add(this.lblPassword);
            this.grpConnectionData.Controls.Add(this.lblUserName);
            this.grpConnectionData.Controls.Add(this.lblServer);
            this.grpConnectionData.Controls.Add(this.lblHeader);
            this.grpConnectionData.HeaderText = "بيانات الاتصال";
            this.grpConnectionData.Location = new System.Drawing.Point(12, 12);
            this.grpConnectionData.Name = "grpConnectionData";
            this.grpConnectionData.Size = new System.Drawing.Size(359, 198);
            this.grpConnectionData.TabIndex = 0;
            this.grpConnectionData.Text = "بيانات الاتصال";
            // 
            // cboDatabase
            // 
            this.cboDatabase.Location = new System.Drawing.Point(36, 152);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(173, 20);
            this.cboDatabase.TabIndex = 16;
            this.cboDatabase.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CboDatabase_SelectedIndexChanged);
            this.cboDatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CboDatabase_MouseClick);
            // 
            // cboServer
            // 
            this.cboServer.Location = new System.Drawing.Point(65, 52);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(144, 20);
            this.cboServer.TabIndex = 15;
            // 
            // btnGetServers
            // 
            this.btnGetServers.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetServers.ImageIndex = 0;
            this.btnGetServers.ImageList = this.img;
            this.btnGetServers.Location = new System.Drawing.Point(36, 51);
            this.btnGetServers.Name = "btnGetServers";
            this.btnGetServers.Size = new System.Drawing.Size(23, 24);
            this.btnGetServers.TabIndex = 11;
            this.btnGetServers.Click += new System.EventHandler(this.BtnGetServers_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "icons8-connected-24.png");
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(36, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(36, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // chkIntegratedSecurity
            // 
            this.chkIntegratedSecurity.Location = new System.Drawing.Point(140, 129);
            this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
            this.chkIntegratedSecurity.Size = new System.Drawing.Size(69, 18);
            this.chkIntegratedSecurity.TabIndex = 5;
            this.chkIntegratedSecurity.Text = "اتصال امن";
            this.chkIntegratedSecurity.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ChkIntegratedSecurity_ToggleStateChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(252, 152);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(70, 18);
            this.lblDatabase.TabIndex = 4;
            this.lblDatabase.Text = "قاعدة البيانات";
            this.lblDatabase.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(264, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "كلمة المرور";
            this.lblPassword.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(248, 82);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "اسم المستخدم";
            this.lblUserName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(210, 52);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(112, 18);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "الجهاز المركزي (Server)";
            this.lblServer.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(52, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(255, 18);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ادخل بيانات الاتصال بقاعدة البيانات ثم اضغط \"اتصال\"";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpBackup
            // 
            this.grpBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.chkDate);
            this.grpBackup.Controls.Add(this.btnBrowse);
            this.grpBackup.Controls.Add(this.txtName);
            this.grpBackup.Controls.Add(this.txtLocation);
            this.grpBackup.Controls.Add(this.lblName);
            this.grpBackup.Controls.Add(this.lblLocation);
            this.grpBackup.Controls.Add(this.lblHeader2);
            this.grpBackup.Enabled = false;
            this.grpBackup.HeaderText = "بيانات النسخ الاحتياطي";
            this.grpBackup.Location = new System.Drawing.Point(10, 13);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(318, 198);
            this.grpBackup.TabIndex = 1;
            this.grpBackup.Text = "بيانات النسخ الاحتياطي";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(110, 162);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(110, 24);
            this.btnBackup.TabIndex = 13;
            this.btnBackup.Text = "نسخ";
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // chkDate
            // 
            this.chkDate.Location = new System.Drawing.Point(84, 119);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(136, 18);
            this.chkDate.TabIndex = 12;
            this.chkDate.Text = "تحديد الاسم حسب التاريخ";
            this.chkDate.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ChkDate_ToggleStateChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(21, 62);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(54, 24);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(81, 64);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(139, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(226, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "اسم النسخة";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(226, 65);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 18);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "موقع النسخ";
            this.lblLocation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeader2
            // 
            this.lblHeader2.Location = new System.Drawing.Point(78, 36);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(163, 18);
            this.lblHeader2.TabIndex = 1;
            this.lblHeader2.Text = "حدد موقع واسم النسخة الاحتياطية";
            this.lblHeader2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "خروج";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PageView
            // 
            this.PageView.Controls.Add(this.BackupPage);
            this.PageView.Controls.Add(this.RestorePage);
            this.PageView.DefaultPage = this.BackupPage;
            this.PageView.Location = new System.Drawing.Point(12, 223);
            this.PageView.Name = "PageView";
            this.PageView.SelectedPage = this.RestorePage;
            this.PageView.Size = new System.Drawing.Size(359, 273);
            this.PageView.TabIndex = 15;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.PageView.GetChildAt(0))).ShowItemPinButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.PageView.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Top;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.PageView.GetChildAt(0))).ShowItemCloseButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.PageView.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.PageView.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Auto;
            // 
            // BackupPage
            // 
            this.BackupPage.Controls.Add(this.grpBackup);
            this.BackupPage.ItemSize = new System.Drawing.SizeF(91F, 28F);
            this.BackupPage.Location = new System.Drawing.Point(10, 37);
            this.BackupPage.Name = "BackupPage";
            this.BackupPage.Size = new System.Drawing.Size(338, 225);
            this.BackupPage.Text = "النسخ الاحتياطي";
            // 
            // RestorePage
            // 
            this.RestorePage.Controls.Add(this.grpRestore);
            this.RestorePage.ItemSize = new System.Drawing.SizeF(137F, 28F);
            this.RestorePage.Location = new System.Drawing.Point(10, 37);
            this.RestorePage.Name = "RestorePage";
            this.RestorePage.Size = new System.Drawing.Size(338, 225);
            this.RestorePage.Text = "استعادة النسخة الاحتياطية";
            // 
            // grpRestore
            // 
            this.grpRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnBrowseRestore);
            this.grpRestore.Controls.Add(this.txtRestoreLocation);
            this.grpRestore.Controls.Add(this.lblRestoreLocation);
            this.grpRestore.Controls.Add(this.lblRestoreHeader);
            this.grpRestore.Enabled = false;
            this.grpRestore.HeaderText = "بيانات الاستعادة";
            this.grpRestore.Location = new System.Drawing.Point(10, 13);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(318, 198);
            this.grpRestore.TabIndex = 2;
            this.grpRestore.Text = "بيانات الاستعادة";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(110, 162);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(110, 24);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.Text = "استعادة";
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Location = new System.Drawing.Point(21, 62);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(54, 24);
            this.btnBrowseRestore.TabIndex = 11;
            this.btnBrowseRestore.Text = "...";
            this.btnBrowseRestore.Click += new System.EventHandler(this.BtnBrowseRestore_Click);
            // 
            // txtRestoreLocation
            // 
            this.txtRestoreLocation.Location = new System.Drawing.Point(81, 64);
            this.txtRestoreLocation.Name = "txtRestoreLocation";
            this.txtRestoreLocation.ReadOnly = true;
            this.txtRestoreLocation.Size = new System.Drawing.Size(139, 20);
            this.txtRestoreLocation.TabIndex = 7;
            // 
            // lblRestoreLocation
            // 
            this.lblRestoreLocation.Location = new System.Drawing.Point(226, 65);
            this.lblRestoreLocation.Name = "lblRestoreLocation";
            this.lblRestoreLocation.Size = new System.Drawing.Size(66, 18);
            this.lblRestoreLocation.TabIndex = 3;
            this.lblRestoreLocation.Text = "موقع النسخة";
            this.lblRestoreLocation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRestoreHeader
            // 
            this.lblRestoreHeader.Location = new System.Drawing.Point(40, 37);
            this.lblRestoreHeader.Name = "lblRestoreHeader";
            this.lblRestoreHeader.Size = new System.Drawing.Size(239, 18);
            this.lblRestoreHeader.TabIndex = 1;
            this.lblRestoreHeader.Text = "حدد موقع واسم النسخة الاحتياطية المراد استعادتها";
            this.lblRestoreHeader.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files|*.*";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(152, 507);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(219, 24);
            this.progressBar.TabIndex = 16;
            this.progressBar.Text = "0 %";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(385, 543);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.PageView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpConnectionData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة قواعد البيانات";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpConnectionData)).EndInit();
            this.grpConnectionData.ResumeLayout(false);
            this.grpConnectionData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIntegratedSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBackup)).EndInit();
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageView)).EndInit();
            this.PageView.ResumeLayout(false);
            this.BackupPage.ResumeLayout(false);
            this.RestorePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpRestore)).EndInit();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestoreLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRestoreLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRestoreHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox grpConnectionData;
        private Telerik.WinControls.UI.RadLabel lblHeader;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadCheckBox chkIntegratedSecurity;
        private Telerik.WinControls.UI.RadLabel lblDatabase;
        private Telerik.WinControls.UI.RadLabel lblPassword;
        private Telerik.WinControls.UI.RadLabel lblUserName;
        private Telerik.WinControls.UI.RadLabel lblServer;
        private Telerik.WinControls.UI.RadGroupBox grpBackup;
        private Telerik.WinControls.UI.RadLabel lblHeader2;
        private Telerik.WinControls.UI.RadTextBox txtLocation;
        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblLocation;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadButton btnBrowse;
        private Telerik.WinControls.UI.RadCheckBox chkDate;
        private Telerik.WinControls.UI.RadButton btnBackup;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnGetServers;
        private System.Windows.Forms.ImageList img;
        private Telerik.WinControls.UI.RadDropDownList cboServer;
        private Telerik.WinControls.UI.RadDropDownList cboDatabase;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
        private Telerik.WinControls.UI.RadPageView PageView;
        private Telerik.WinControls.UI.RadPageViewPage BackupPage;
        private Telerik.WinControls.UI.RadPageViewPage RestorePage;
        private Telerik.WinControls.UI.RadGroupBox grpRestore;
        private Telerik.WinControls.UI.RadButton btnRestore;
        private Telerik.WinControls.UI.RadButton btnBrowseRestore;
        private Telerik.WinControls.UI.RadTextBox txtRestoreLocation;
        private Telerik.WinControls.UI.RadLabel lblRestoreLocation;
        private Telerik.WinControls.UI.RadLabel lblRestoreHeader;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Telerik.WinControls.UI.RadProgressBar progressBar;
    }
}

