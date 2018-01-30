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
    public partial class frmAddCard : Form
    {

        public FormMode mode;

        public frmAddCard(FormMode mode)
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
            dtExpiry.Format = DateTimePickerFormat.Custom;
            dtExpiry.CustomFormat = "MM/yyyy";
            cboCardType.DataSource = Constants.cardtypes;
        }

        private void frmAddCard_Load(object sender, EventArgs e)
        {

        }

        private void cboCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCardType.Text)
            {
                case Constants.CARDTYPE_VISA:
                    pbxCardType.Image = Properties.Resources.Visa;
                    break;
                case Constants.CARDTYPE_MASTERCARD:
                    pbxCardType.Image = Properties.Resources.Mastercard;
                    break;
                case Constants.CARDTYPE_AMEX:
                    pbxCardType.Image = Properties.Resources.AMEX;
                    break;
                case Constants.CARDTYPE_DISCOVER:
                    pbxCardType.Image = Properties.Resources.Discover;
                    break;
            }
        }
    }
}
