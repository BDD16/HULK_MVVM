using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HULK.Model;
using System.Security.Cryptography;
using System.IO;
using System.Security;



namespace HULK.Model
{ /*//***** Class Description   *****/
    //***** Name: Hulk Authentication   *****//
    //***** Description: This class is to authenticate users. This class is also to give the neccessary   *****//
    //***** functions in order to encrypt and decrypt using  Symetric   *****//
    //***** as well as Asymetric Algorithms if it becomes too large   *****//
    //***** the class may then be turned into a wrapper where all    *****//
    //***** encryption services inherit the HulkAuthentication base class   *****//
    //***** and the implementation of algorithms occurs in a newly defined child class   *****//
    //*****                       *****//     */
    class HulkAuthentication
    {

        public Boolean AuthenticateUser(string username, string cipherpwd)
        {
            //0)establish local variables
            string usercopy = username;
            string cipherpwdcopy = cipherpwd;


            //1)compare username in that it exists
            if (DoesUserExist(username))
            {//1)the user exists now decrypt cipherpwd

                //2)compare decrypted cipherpwd with true pwd for username
                string truepwd = fetchtruepwd(usercopy);

                if(Comparepwd(cipherpwdcopy, truepwd))
                {
                    return true;
                }
                else
                {   //the pwd does not match therefore throw a pop up window
                    MessageBox.Show("invalid username or password please try again");
                    return false;
                }

            }

            //to test that the button click changes view this needs to return true

            //user does not exist so return false for authentication 
            //1)the user does not exist therefore show an inablility to login window
            MessageBox.Show("invalid username or password please try again");
    
            return false;

            //

        }

        public Boolean AuthenticateUser(string username, System.Security.SecureString securePwd)
        {//ToDo: implement comparing the SecureString userinput with a plaintext username string
            //1)make sure that the username even exists
            string TruePwd = null;
            TruePwd = fetchtruepwd(username);
            Comparepwd(securePwd, TruePwd);

            //2)Once the username is confirmed that exists, then fetch the usernames true pwd
                    //check txt file or make a delta cache file

            //3)compare true pwd with Secure String


                //3a) if the true and entered credentials are correct then move to the HomeScreen view


            return true;//return true for debug purposes
        }

        private void Comparepwd(SecureString securePwd, string truePwd)
        {
            if (securePwd.Length != truePwd.Length)
            {
                throw new NotImplementedException();
                MessageBox.Show("Invalid Username Or Password");

            }
        }

        public Boolean DoesUserExist(string username)
        {
            List<string> usernamelist = new List<string>();
            string filename = ""; //TBD
            

            int userelement = usernamelist.IndexOf(username);
            //1)convert username file to list

            //2)search for username in list
            if( userelement != -1)
            { //the user does exist within the database
                return true;

            }

            return false;
        }

        public Boolean Comparepwd(string cipherpwd, string truepwd)
        {
            string decryptedpwd = Decrypt(cipherpwd);
            if(decryptedpwd == truepwd)
            {
                return true;
            }
            return false;
        }

        public string fetchtruepwd(string username)
        {
            string encryptedpwd = "";
            string truepwd = "" ;
            string decryptedpwd = "";
            //1)from the username look up encrypted password

            //2)decrypt encrypted password
            decryptedpwd = Decrypt(encryptedpwd);
            //3)return decrypted password
            truepwd = decryptedpwd;
            return truepwd;
        }

        public string Decrypt(string ciphertext)
        {   //wrapper for veracrypt
            string decrypted = "";

            //1)determine encryption scheme (look at settings)

            //2)decrypt according to algorithm

            //3)return decrypted value
            return decrypted;

        }

        static byte[] EncryptString_Aes(string plaintext, byte[] key, byte[] IV)
        {   //Encrypt a plaintext string but first make sure that they are not null
            if((plaintext == null) ||( plaintext.Length <=0))
            {
                throw new ArgumentException("plaintext");
            }

            if((key == null) || (key.Length <= 0))
            {
                throw new ArgumentException("Key");
            }

            if((IV == null) || (IV.Length <= 0)){

            }

            //establish local variables
            byte[] encrypted;

            using(AesCryptoServiceProvider aesobject = new AesCryptoServiceProvider())
            {   //1)initialize aes symetric algorithm object
                aesobject.Key = key;
                aesobject.IV = IV;

                //2)create a decrytor to perform stream transformation
                ICryptoTransform encryptor = aesobject.CreateEncryptor(aesobject.Key, aesobject.IV);

                //3)create the stream used for encryption
                using(MemoryStream Encrypt = new MemoryStream())
                {
                    using(CryptoStream csEncrypt = new CryptoStream(Encrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //1)all streams and encryptors have been initialized now time to encrypt
                            swEncrypt.Write(plaintext);
                        }

                        encrypted = Encrypt.ToArray();
                    }
                }

            }

            //4)return encrypted string in byte array
            return encrypted;
        }

       static string DecryptString_Aes(byte[] ciphertext, byte[] key, byte[] IV)
        {//1) check for null and special cases
            if( key.Length == 32)
            {//Key inserted is 256 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {

                    //3)create AesCryptoServiceProvider object (allows for decryption)
                    //3)a call AES Microsoft AES methods to decrypt
                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }
                return null;
            }

            else if(key.Length == 16)
            {//key inserted is 128 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {
                    //3)create AesCryptoServiceProvider object (allows for decryption)

                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }

                return null;//ciphertext length is zero
            }

            else
            {//throw an exception and let the user know that the key inserted is not supported
                MessageBox.Show("Key inserted is unsupported, must be either 128bit or 256bit length");
            }

           //a return of null is due to unsupported key length

            return null; //will change in near future

        }

        static byte[] EncryptString_Swordfish(string plaintext, byte[] key, byte[] IV)
        {//TO DO: Create and use c++ Wrapper for TwoFish
            byte[] encryptedstring = null;

            return encryptedstring;

        }

        static string DecryptString_Swordfish(byte[] ciphertext, byte[] key, byte[] IV)
        {//TO DO: Create and use c++ Wrapper for TwoFish
            //1) check for null and special cases
            if (key.Length == 32)
            {//Key inserted is 256 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {

                    //3)create AesCryptoServiceProvider object (allows for decryption)
                    //3)a call Veracrypt Swordfish methods to decrypt
                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }
                return null;
            }

            else if (key.Length == 16)
            {//key inserted is 128 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {
                    //3)create AesCryptoServiceProvider object (allows for decryption)

                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }

                return null;//ciphertext length is zero
            }

            else
            {//throw an exception and let the user know that the key inserted is not supported
                MessageBox.Show("Key inserted is unsupported, must be either 128bit or 256bit length");
            }

            //a return of null is due to unsupported key length

            return null; //will change in near future


        }

        static byte[] EncryptString_Cameilia(string plaintext, byte[] key, byte[] IV)
        {//TO DO: Create and use c++ wrapper for Camellia
            byte[] encryptedstring = null;

            return encryptedstring;


        }

        static string Decryptstring_Cameilia(byte[] ciphertext, byte[] key, byte[] IV)
        {//TO DO: Create and use c++ Wrapper for Camelia
            //1) check for null and special cases
            if (key.Length == 32)
            {//Key inserted is 256 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {

                    //3)create AesCryptoServiceProvider object (allows for decryption)
                    //3)a call Veracrypt Cameilia methods to decrypt
                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }
                return null;
            }

            else if (key.Length == 16)
            {//key inserted is 128 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {
                    //3)create AesCryptoServiceProvider object (allows for decryption)

                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }

                return null;//ciphertext length is zero
            }

            else
            {//throw an exception and let the user know that the key inserted is not supported
                MessageBox.Show("Key inserted is unsupported, must be either 128bit or 256bit length");
            }

            //a return of null is due to unsupported key length

            return null; //will change in near future

        }

        static byte[] EncryptString_Serpent(string plaintext, byte[] key, byte[] IV)
        { //create warpper for c++ Serpent
            byte[] encrypted = null;

          

            return encrypted;
        }

        static string Decyryptstring_Serpent(byte[] ciphertext, byte[] key, byte[] IV)
        {//create wrapper for c++ Serpent
            //1) check for null and special cases
            if (key.Length == 32)
            {//Key inserted is 256 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {

                    //3)create AesCryptoServiceProvider object (allows for decryption)
                    //3)a call Veracrypt Serpent methods to decrypt
                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }
                return null;
            }

            else if (key.Length == 16)
            {//key inserted is 128 bit key
             //2)declare local variables
                string plaintext = "";//null at initialization
                if (ciphertext.Length > 0)
                {
                    //3)create AesCryptoServiceProvider object (allows for decryption)

                    //4)create the streams used for decryption

                    //5)return decrypted ciphertext as plain text
                    return plaintext;
                }

                return null;//ciphertext length is zero
            }

            else
            {//throw an exception and let the user know that the key inserted is not supported
                MessageBox.Show("Key inserted is unsupported, must be either 128bit or 256bit length");
            }

            //a return of null is due to unsupported key length

            return null; //will change in near future


        }

        public static byte[] SecureStringtoByteArray(SecureString value)
        {//convert a Secure String into readable and usable data.
            byte[] Returnvalue = new byte[value.Length];

            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemUnicode(value);
                for(int i=0; i< value.Length; i += 1)
                {
                    short uniChar = System.Runtime.InteropServices.Marshal.ReadInt16(valuePtr, i * 2);
                    Returnvalue[i] = Convert.ToByte(uniChar);
                }
                return Returnvalue;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }

        }

        public static byte[] calculateHash(byte[] inputBytes)
        {//generate a SHA256Managed Hash
            SHA256Managed algo = new SHA256Managed();
            algo.ComputeHash(inputBytes);
            return algo.Hash;
        }

        public static bool CompareHash(byte[] original, byte[] UserInput)
        { //compares any generic hash, however this should be a SHA256Managed hashing function.
            if((original == null) || (UserInput == null))
            {//the password cannot be empty or null.
                throw new ArgumentNullException(original == null ? "original" : "UserInput", "Byte arrays cannot be null");
            }

            if((original.Length == 0) != (UserInput.Length == 0))
            {//they have different length of hashes therefore they are not equal.
                return false;
            }

            for(int i = 0; i < original.Length; i += 1)
            {//compare original hash with new hash
                if(original[i] != UserInput[i])
                {
                    return false;//the hashes are not equal therefore return false
                }
            }

            return true;   //We made it to the end of the code therefore it has passed and hashes match
        }


    }
}
