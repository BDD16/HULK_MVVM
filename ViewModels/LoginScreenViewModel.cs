using HULK.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HULK;
using HULK.Model;
using HULK.Views;
using System.Security;
using System.Runtime.InteropServices;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace HULK.ViewModels
{


    class LoginScreenViewModel : ViewModelBase
    { /*//***** Class Description   *****/
      //***** Name: LoginScreenViewModel.cs    *****//
      //***** Description: ViewModel for LoginScreen, button logic  *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****                       *****//     */

      //get the title of the page
        public string Title { get; private set; }
        public byte LoginAttempts; //set as property so that everytime the login button is clicked it increments by 1
        public string _userNameLogin;
        public string _password;
        
        
        public string Username
        {
            get { return _userNameLogin; }
            set
            {   
                _userNameLogin = value;
                BatCave.Username = value;//pass parameter to another class do something similiar to the user entered password
            }
        }

        public byte Attempts
        {
            get { return LoginAttempts; }
            set
            {
                LoginAttempts += 1;
                BatCave.UserAttempts = LoginAttempts;
            }
        }



       

        private ICommand mUpdater;
        public ICommand button_Click
        {
            get
            {
                if (mUpdater == null)
                {
                    mUpdater = new BatCave();
                   

                }

               
                return mUpdater;
            }
            set
            {
                
                mUpdater = value;

            }
        }


        class BatCave : ICommand   //this is a RelayCommand
        {
            public static string Username;
            public static byte UserAttempts;
            public System.Security.SecureString SecurePassword;

            #region ICommand Members

            public bool CanExecute(object parameter)
            {
                
                return true;
            }
            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }


            private void LoginWithPwd(object parameter)
            {
                var passwordContainer = parameter as PasswordBox;
                if (passwordContainer != null)
                {
                    System.Security.SecureString secureString = passwordContainer.SecurePassword;
                    passwordContainer = null;
                    SecurePassword = secureString;//update secure string
                  //  _password = ConvertToUnsecureString(secureString);//used only for testing will need to just use a secure string
                }
            }

            private string ConvertToUnsecureString(SecureString securePassword)
            {
                if (securePassword == null)
                {
                    return string.Empty;
                }

                IntPtr unmanagedString = IntPtr.Zero;
                try
                {
                    unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                    return Marshal.PtrToStringUni(unmanagedString);
                }
                finally
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
                }
            }

            public void Execute(object parameter)
            {
                //0)implement string comparision between a database password and user entered password (verifying between plain text string and encrypted string)
                //1) need to authenticate a user based on user name and password (if() statement)
                string username = "";
                
              
                //remember to never put the REAL password into plain text, user entered password is okay for now.
                username = Username;
                LoginWithPwd(parameter);//set SecurePassword with the passwordBox in the view
                
                if((UserAttempts > 5) && (UserAttempts > 0))
                {//we have reached are maximum attempts of  logins
                    MessageBox.Show("You have failed 5 times at logging in. Lets try this again.");
                    UserAttempts = 1;//For now just reset the user attempts
                    
                }
                //done with using a new view model so mark for deletion by garbage collector


                HulkAuthentication authenticationObject = new HulkAuthentication();
                //TO DO: FIND OUT HOW TO GET TEXT BOXES FROM VIEW TO STRING (CONTENT BINDING TO ANOTHER FUNCTION?)

                if (authenticationObject.AuthenticateUser(username, SecurePassword))//right now no authentication, just testing view loading by button click
                {//2) after authentication you should change views to the HomeScreen (
                 //2b) the homescreen should be personalized to the user
                 //a)create new viewmodel object
                    HomeScreenViewModel HomeScreen = new HomeScreenViewModel();
                    //b)Delete old view model object (LoginScreenViewModel) [not sure if need to, due to garbage collector]

                    //c)set main window data context to newly created view model
                    App.Current.MainWindow.DataContext = null; //delete LoginViewModel instance
                    App.Current.MainWindow.DataContext = HomeScreen;  //set the newly created HomeScreen Viewmodel instance to the DataContext of the shell
                    //d)load view into the main window
                    Injector.LoadView("Views/HomeScreen.xaml");
                    //IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
                    //IRegion region = regionManager.Regions["TabRegion"];
                    //region.Add
                    
                    

                      
                }
                else
                {   //have a finite number of tries before username locks for specified period of time

                    MessageBox.Show("HULK SMASH: Wrong Username or Password");


                }

                //Done with encrypting so delete authentication object
                authenticationObject = null;


            }
            #endregion

        }
    }
}

