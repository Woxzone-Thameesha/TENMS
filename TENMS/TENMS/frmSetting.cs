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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_SizeChanged(object sender, EventArgs e)
        {
            #region Header
            this.pnlHeader.Location = new Point(0, 35);
            this.pnlHeader.Size = new Size(this.Width, 2);
            this.lblHeader.Location = new Point(1, 1);
            this.lblHeader.BackColor = Color.Transparent;
            #endregion

            #region Footer
            this.btnSave.Location = new Point(this.Width-135,this.Height-40);
            this.btnSave.Size = new Size(130, 35);
            #endregion
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
