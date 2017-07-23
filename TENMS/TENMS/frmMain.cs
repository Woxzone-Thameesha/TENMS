using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TENMS
{
    public partial class frmMain : Form
    {
        private int MainWidth;
        private int MainHeight;

        #region Objects
        Master_Form.frmDashboard Dashboard = new Master_Form.frmDashboard();
        frmSetting Setting = new frmSetting();
        #endregion

        public frmMain()
        {
            InitializeComponent();
            #region Form
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            #endregion

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Header
            //this.pnlHeader.Anchor = AnchorStyles.Top;
            MainWidth = this.Width;
            MainHeight = this.Height;
            this.btnClose.Location = new Point(MainWidth - 45,-28);
            this.btnMinimize.Location = new Point(MainWidth - 90, -34);
            this.btnHelp.Location = new Point(MainWidth - 120, 0);
            this.pnlHeader.Location = new Point(0, 26);
            this.pnlHeader.Size = new Size(MainWidth, 2);
            #endregion

            #region SubHeader
            this.pnlSubHeader.Location = new Point(0, 28);
            this.pnlSubHeader.Size = new Size(MainWidth, 50);
            this.btnMainMenu.Location = new Point(10,10);
            this.btnSetting.Location = new Point(MainWidth-40, 10);
            this.lblProfile.Location = new Point(MainWidth - 110, 15);
            this.btnProfile.Location = new Point(MainWidth-145,10);
            #endregion

            #region MainMenu Panel
            this.pnlMainMenu.Location = new Point(0, 78);
            this.pnlMainMenu.Size = new Size(55, MainHeight-78);
            #endregion

            #region MDI Container
            this.pnlMDI.Location = new Point(54,78);
            this.pnlMDI.Size = new Size(MainWidth-54,MainHeight-77);
            this.pnlMDI.MaximumSize = new Size(MainWidth - 54, MainHeight - 77);
            this.pnlMDI.Enabled = true;
            #endregion

            #region MainMenuButtons
            this.btnDashboard.Location = new Point(0, 5);
            this.btnDashboard.Size = new Size(200,36);

            this.btnAttendance.Location = new Point(0, 38);
            this.btnAttendance.Size = new Size(200, 36);

            this.btnEmployee.Location = new Point(0, 76);
            this.btnEmployee.Size = new Size(200, 36);

            this.btnLeave.Location = new Point(0, 114);
            this.btnLeave.Size = new Size(200, 36);

            this.btnPayroll.Location = new Point(0, 152);
            this.btnPayroll.Size = new Size(200, 36);
            #endregion

            #region DashBoard Open
            DashboardOpen();
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if(this.pnlMainMenu.Width == 200)
            {
                #region MDI Container
                this.pnlMDI.Location = new Point(54, 77);
                this.pnlMDI.Size = new Size(MainWidth - 54, MainHeight - 77);
                this.pnlMDI.Enabled = true;
                #endregion

                this.pnlMainMenu.Location = new Point(0, 78);
                this.pnlMainMenu.Size = new Size(55, MainHeight - 78);

                FormRefresh(Dashboard);
            }
            else
            {
                #region MDI Container
                this.pnlMDI.Location = new Point(199, 77);
                this.pnlMDI.Size = new Size(MainWidth - 199, MainHeight - 77);
                this.pnlMDI.Enabled = true;
                #endregion

                this.pnlMainMenu.Location = new Point(0, 78);
                this.pnlMainMenu.Size = new Size(200, MainHeight - 78);

                FormRefresh(Dashboard);
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardOpen();
        }

        public void DashboardOpen()
        {
            try
            {
                Master_Form.frmDashboard open = Application.OpenForms["frmDashboard"] as Master_Form.frmDashboard;
                if (open == null)
                {
                    
                    Dashboard.MdiParent = pnlMDI.MdiForm;
                    Dashboard.Show();
                    Dashboard.Focus();
                    Dashboard.Location = new Point(0, 0);
                    Dashboard.Width = pnlMDI.Width - 5;
                    Dashboard.Height = pnlMDI.Height - 5;
                }
                else
                {
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FormRefresh(Form form)
        {
            form.Width = pnlMDI.Width - 5;
            form.Height = pnlMDI.Height - 5;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingsOpen();
            Dashboard.Hide();
        }

        public void SettingsOpen()
        {
            try
            {
                frmSetting open = Application.OpenForms["frmSetting"] as frmSetting;
                if (open == null)
                {

                    Setting.MdiParent = pnlMDI.MdiForm;
                    Setting.Show();
                    Setting.Focus();
                    Setting.Location = new Point(0, 0);
                    Setting.Width = pnlMDI.Width - 5;
                    Setting.Height = pnlMDI.Height - 5;
                }
                else
                {
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
