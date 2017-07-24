using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TENMS.Master_Form
{
    public partial class frmDashboard : Form
    {
        private int FormWidth;
        private int FormHeight;
        public frmDashboard()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void frmDashboard_SizeChanged(object sender, EventArgs e)
        {
            #region Header
            this.pnlHeader.Location = new Point(0, 35);
            this.pnlHeader.Size = new Size(this.Width, 2);
            this.lblHeader.Location = new Point(1, 1);
            this.lblHeader.BackColor = Color.Transparent;
            #endregion
        }
    }
}
