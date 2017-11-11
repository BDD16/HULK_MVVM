using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HULK;

namespace HULK.Model
{
    /*//***** Class Description   *****/
    //***** Name:    Injector  *****//
    //***** Description: This class relays a method to inject views to the MainWindow  *****//
    //*****                                                                            *****//
    //*****                                                                            *****//  */
    class Injector
    {
        public static void LoadView(string viewlocation)
        {
            System.Uri resourceLocater = new System.Uri("/HULK;component/" + viewlocation, System.UriKind.Relative);
            
            System.Windows.Application.LoadComponent(HULK.App.Current.MainWindow, resourceLocater);
            
        }
    }
}
