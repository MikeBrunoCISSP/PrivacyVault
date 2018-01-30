using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivacyVault
{
    public enum FormMode
    {
        Add=0,
        Update=1
    }

    class Constants
    {
        //Credit Card Types
        public const string CARDTYPE_VISA = "Visa";
        public const string CARDTYPE_MASTERCARD = "Mastercard";
        public const string CARDTYPE_AMEX = "American Express";
        public const string CARDTYPE_DISCOVER = "Discover";

        //Submit Button Labels
        public const string SUBMIT_NEW = "Add";
        public const string SUBMIT_UPDATE = "Update";

        public static readonly string[] cardtypes = { CARDTYPE_VISA, CARDTYPE_MASTERCARD, CARDTYPE_AMEX, CARDTYPE_DISCOVER };
    }
}
