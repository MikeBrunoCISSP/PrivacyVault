using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivacyVault
{
    class Vault
    {
    }

    class Password : Secret
    {
        public Password(string password)
        :base(password)
        {
        }
    }

    class PCN : Secret
    {

        public PCN(string cardNumber)
            : base(cardNumber)
        {
            displayText = "....." + cardNumber.Substring(cardNumber.Length - 4);
        }
    }

    class CCV : Secret
    {
        public CCV(string ccv, string cardType)
            :base(ccv)
        {
            switch (cardType)
            {
                case Constants.CARDTYPE_AMEX:
                    displayText = "****";
                    break;
                default:
                    displayText = "***";
                    break;
            }
        }
    }

    class Secret
    {
        private static cryptoHandler cHandler;
        private static bool gotCryptoHandler = false;
        private string ciphertext;

        public string displayText;

        public Secret(cryptoHandler ch, string plaintext)
        {
            cHandler = ch;
            gotCryptoHandler = true;
            ciphertext = cHandler.Encrypt(plaintext);
            displayText = "********";
        }

        public Secret(string plaintext)
        {
            if (!gotCryptoHandler)
                throw new NoCryptoHandlerException();

            ciphertext = cHandler.Encrypt(plaintext);
        }

        public string CipherText
        {
            get
            {
                return ciphertext;
            }
            set
            {
                ciphertext = cHandler.Encrypt(value);
            }
        }

        public string decrypt()
        {
            return cHandler.Decrypt(ciphertext);
        }
    }

    public class NoCryptoHandlerException : Exception
    {
        public NoCryptoHandlerException()
            : base()
        { }
    }
}
