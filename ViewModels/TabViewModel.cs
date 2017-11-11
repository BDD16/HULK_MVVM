using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HULK.Model;
using HULK.ViewModels;

namespace HULK.ViewModels
{
    class TabViewModel : ViewModelBase
    {
        private ICommand mUpdater3;
        private ICommand mUpdater4;
        public ICommand Logout_Click
        {
            get
            {
                if (mUpdater3 == null)
                    mUpdater3 = new HulkToBruce();
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
                    mUpdater4 = new HulkToProff();
                return mUpdater4;
            }
            set
            {
                mUpdater4 = value;
            }
        }
    }
    class HulkToBruce : ICommand
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

            //3)Link LoginScreenViewModel with MainWindow Shell
            App.Current.MainWindow.DataContext = null;
            LoginScreenViewModel LoginScreenViewModel = new LoginScreenViewModel();
            App.Current.MainWindow.DataContext = LoginScreenViewModel;

            //3) Display the Login View in the Main Window.
            Injector.LoadView("Views/LoginScreen.xaml");
            
        }

        #endregion
    }

    class HulkToProff : ICommand
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
            SettingsViewModel SettingsViewModel = new SettingsViewModel();
            App.Current.MainWindow.DataContext = SettingsViewModel;

            //3) Display the Settings View in the Main Window.
            Injector.LoadView("Views/PartialViews/SettingsView.xaml");

        }

        #endregion
    }


}



