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
using Microsoft.Practices.Prism.Regions;
using HULK;
using HULK.Model;

namespace HULK.ViewModels
{
    class HomeScreenViewModel : ViewModelBase
    { /*//***** Class Description   *****/
      //***** Name:HomeScreenViewModel.cs     *****//
      //***** Description: this class is to   *****//
      //***** Be The code behind the view     *****//
      //***** for the HomeScreenView where    *****//
      //***** the user interacts with the most*****//
      //*****                                 *****//   */
      //get page title
        public string Title { get; private set; }

        private ICommand mUpdater;
        public ICommand SendMessage_Click
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new SendMessageSmash();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private ICommand mUpdater3;
        private ICommand mUpdater4;
        public ICommand Logout_Click
        {
            get
            {
                if (mUpdater3 == null)
                    mUpdater3 = new HulkToBruceSettings();
                return mUpdater3;
            }
            set
            {
                mUpdater3 = value;
            }
        }

        public ICommand Settings_Click
        {
            get
            {
                if (mUpdater4 == null)
                    mUpdater4 = new HulkToProffSettings();
                return mUpdater4;
            }
            set
            {
                mUpdater4 = value;
            }
        }
    }
    class SendMessageSmash : ICommand
    {
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


        public void Execute(object parameter)
        {   //code to implement sending a message  lots of TO DO:

            //1)What needs to be done is to check if message is already encrypted

            //3)display encrypting animation

            //4)/if not encrypted then encrypt using friends public key
            //4a)Determine who is the friend that user is sending to

            //4b)look up friends public key (decrypt key)

            //4c)Encrypt message with friends public key



            //5)send data message packet to friend

            //6)display message in chat conversation
        }

        #endregion
    }

    class HulkToBruceSettings : ICommand
    {/*//***** Class Description   *****/
     //***** Name: HulkToBruce     *****//
     //***** Description: This class implements a command when a user clicks the LogoutButton  *****//
     //*****    *****//
     //*****    *****//
     //*****    *****//
     //*****    *****//
     //*****    *****//
     //*****                       *****//     */
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


        public void Execute(object parameter)
        {   //code to implement Logging out (Hulk transforms back to Bruce), Click on LogoutButton will call this method

            //1)What needs to be done is to check if message is already encrypted

            //2)delete objects, disconnect from open chats, send last message of (user logged off)
            
            //3)Link LoginScreenViewModel with MainWindow Shell (NEED TO ADDRESS INABILITY TO RE-REGISTER "DAG" IMAGE)
            LoginScreenViewModel LoginScreenViewModel = new LoginScreenViewModel();
            App.Current.MainWindow.DataContext = null;
            App.Current.MainWindow.DataContext = LoginScreenViewModel;
            Injector.LoadView("Views/LoginScreen.xaml");
            //App.Current.MainWindow.Show();

            //3) Display the Login View in the Main Window.
            //Injector.LoadView("Views/LoginScreen.xaml");

        }

        #endregion
    }

    class HulkToProffSettings : ICommand
    {/*//***** Class Description   *****/
     //***** Name: HulkToProff     *****//
     //***** Description: This class implements a command when a user clicks the SettingsButton  *****//
     //*****    *****//
     //*****    *****//
     //*****    *****//
     //*****    *****//
     //*****    *****//
     //*****                       *****//     */
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


        public void Execute(object parameter)
        {   //code to implement Settings View (Hulk transforms back to Proffessor Hulk to be smart enough to change settings),
            //Click on SettingsButton will call this method



            //3)Link LoginScreenViewModel with MainWindow Shell
            //  SettingsViewModel SettingsViewModel = new SettingsViewModel();
            // App.Current.MainWindow.DataContext = SettingsViewModel;
            SettingsViewModel SettingsView = new SettingsViewModel();
            //3) Display the Settings View in the Main Window.
            App.Current.MainWindow.DataContext = null;
            int x = 2;
            x += 1;
            App.Current.MainWindow.DataContext = SettingsView;
            Injector.LoadView("Views/PartialViews/SettingsView.xaml");

        }

        #endregion
    }

}
