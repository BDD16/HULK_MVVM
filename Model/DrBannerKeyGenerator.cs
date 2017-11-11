using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HULK.Model
{
    class DrBannerKeyGenerator
    {//Use this class to generate a key ability for Symetric and Asymetric Key Generation
        static public byte[] TwoFiftySixKey_Symetric()
        {//return 256bit key for symetric crypto algorithms
            byte[] key = null;//null due to needs to be completed

            return key;

        }

        static public byte[] OneTwentyEight_Symetric()
        {//return 128bit key for symetric crypto algorithms
            byte[] key = null;//null due to needs to be completed

            return key;

        }

        static public byte[] TwoFiftySixKey_Asymetric()
        {//although returns a byte[] array will be double in size to split Public/Private key pair
            byte[] keypair = null;//null due to needs to be completed

            return keypair;

        }

        static public byte[] OneTwentyEight_Asymetric()
        {//although returns a byte[] array will be double in size to split Public/Private key pair
            byte[] keypair = null;//null due to needs to be completed

            return keypair;
   
        }


    }
}
