using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace HULK.Model.Messaging
{
    class HulkAsync
    { //this class will be used to connect ports asynchronously

    }

    class PublicTransmitter
    {//this class will be used to gather as well as send public keys to a friend or use to fetch a friends public key.
     //you will also be able to fetch the current users private key.

    }

    class E2EEncryption : HulkAuthentication
    {//this class will enherit some of the symetric encryption fnction found in HulkAuthentication to be used if neccessary.

        private SecureString GetPublicKey()
        {   //UNFINISHED STILL NEED TO IMPLEMENT
            SecureString SecurePubKey = new SecureString();

            return SecurePubKey;
        }

        private SecureString GetPrivateKey()
        {   //UNFINISHED STILL NEED TO IMPLEMENT
            SecureString SecurePrivKey = new SecureString();



            return SecurePrivKey;
        }

        private SecureString GeneratePUBPRIVPairKeys()
        {
            SecureString keys = new SecureString();


            return keys;
        }
        
    }
}
