using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HULK.Model
{  /*//***** Interface Description   *****/
   //***** Name:     *****//
   //***** Description: Password interface to grab securestring from a view  *****//   */
    public interface IHavePassword
        {
            System.Security.SecureString PasswordView { get; }
        }
    
}
