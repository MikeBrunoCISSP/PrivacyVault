using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivacyVault
{
    public partial class frmAddAccount : Form
    {
        public FormMode mode;

        public frmAddAccount(FormMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            switch (mode)
            {
                case FormMode.Add:
                    btnSubmit.Text = Constants.SUBMIT_NEW;
                    break;
                case FormMode.Update:
                    btnSubmit.Text = Constants.SUBMIT_UPDATE;
                    break;
            }
            this.Icon = Properties.Resources.vault;
        }
    }
}
