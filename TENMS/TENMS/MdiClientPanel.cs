using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TENMS
{
    public class MdiClientPanel : Panel
    {
        private Form mdiForm;
        private MdiClient ctlClient = new MdiClient();

        public MdiClientPanel()
        {
            base.Controls.Add(this.ctlClient);
            ctlClient.BackColor = System.Drawing.Color.FromArgb(240,240,240);
        }

        public Form MdiForm
        {
            get
            {
                if (this.mdiForm == null)
                {
                    this.mdiForm = new Form();
                    /// set the hidden ctlClient field which is used to determine if the form is an MDI form
                    System.Reflection.FieldInfo field = typeof(Form).GetField("ctlClient", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    field.SetValue(this.mdiForm, this.ctlClient);
                }
                this.mdiForm.Enabled = true;
                ctlClient.Enabled = true;
                return this.mdiForm;
            }
        }
    }
}
