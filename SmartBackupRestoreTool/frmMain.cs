using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Threading;

namespace SmartBackupRestoreTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            serverManager = new ServerManager();
        }

        ServerManager serverManager;
        Server server;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGetServers_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            
            if (serverManager.CheckSqlBrowserStatus().Equals(ServiceControllerStatus.Running)||
                serverManager.CheckSqlBrowserStatus().Equals(ServiceControllerStatus.StartPending))
            {
                serverManager.FetchServers();
                cboServer.DataSource = serverManager.GetServersNames();
            }
            else
                MessageBox.Show("هناك مشكلة في عرض الاجهزة الرئيسية \n Sql Browser Service");
            this.Cursor = Cursors.Default;
        }

        private void ChkIntegratedSecurity_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            txtUserName.Enabled = !chkIntegratedSecurity.Checked;
            txtPassword.Enabled = !chkIntegratedSecurity.Checked;
        }

        private void CboDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            
            if (chkIntegratedSecurity.Checked)
                server = serverManager.CreateServer(cboServer.Text);
            else
            {
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("لايمكن ترك اسم المستخدم أو كلمة المرور فارغة");
                    this.Cursor = Cursors.Default;
                    return;
                }
                server = serverManager.CreateServer(cboServer.Text, txtUserName.Text, txtPassword.Text);
            }

            try
            {
                cboDatabase.DataSource = serverManager.GetDatabasesNames(server);
            }
            catch (Exception ee)
            {

                throw;
            }

            this.Cursor = Cursors.Default;
        }

        private void CboDatabase_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cboServer.Text) &&
                !string.IsNullOrEmpty(cboDatabase.Text))
            {
                grpBackup.Enabled = true;
            }
            else
                grpBackup.Enabled = false;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFolderDialog.ShowDialog();
            txtLocation.Text = openFolderDialog.SelectedPath;
        }

        private void ChkDate_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (chkDate.Checked)
                txtName.Text = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_Backup";
            else
                txtName.Text = "";
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLocation.Text) ||
                string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("لايجب ترك موقع النسخ او الاسم فارغاً");
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Backup backup = new Backup
            {
                Action = BackupActionType.Database,
                Database = cboDatabase.Text,
                NoRecovery = false
            };

            backup.Devices.AddDevice(txtLocation.Text + "\\" + txtName.Text + ".bak", DeviceType.File);
            backup.SqlBackup(server);
            MessageBox.Show("تمت عملية النسخ");
            this.Cursor = Cursors.Default;
        }
    }
}
