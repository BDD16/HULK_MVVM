using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HULK.ViewModels
{
    class SettingsViewModel : ViewModelBase
    { /*//***** Class Description   *****/
      //***** Name: SettingsViewModel    *****//
      //***** Description: This Viewmodel will do logic after navigating from the Homescreen to an Advanced settings view    *****//
      //***** This SettingsViewModel will be the advance setttings viewmodel where a user can adjust crypto settings         *****//
      //*****  Crypto Settings ability to Choose between Symetric and Asymetric Encryption as well as the associated Algo.   *****//
      //*****  Once Selected what will happen in the background is when hitting the Encryption button those methods are used *****//
      //*****    *****//     */


        //populate combo boxes when user clicks on them perhaps in the constructor we autopopulate the boxes?
        //will need to pass the objects in order to populate

        private ICommand mUpdater1;
        public ICommand EncryptSetting_Click
        {
            get
            {
                if (mUpdater1 == null)
                {
                    mUpdater1 = new EncryptSettingsSwitch();
                }

                return mUpdater1;
            }
            set
            {
                mUpdater1 = value;
            }
        }


        class EncryptSettingsSwitch : ICommand   //this is a RelayCommand
        {/*//***** Class Description   *****/
         //***** Name: EncryptSettingsSwitch    *****//
         //***** Description: This class implements a command when a user clicks the Encrypt Setting Combobox  *****//
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
            {//Execute Command here

                //TO DO: 1)Link command to the SettingsView Label Box.  ideally click on a Label text and It inserts it's associated view
                //      Needs ability to go back to the HomeScreen as well as always have the ablility to LogOut no matter which view you're at
                //      (will need multiple commands linked to each Settings view Label (i.e. populate ComboBoxes)




            }
            #endregion

        }


        private ICommand mUpdater2;
        public ICommand EncryptAlgorithm_Click
        {
            get
            {
                if (mUpdater2 == null)
                {
                    mUpdater2 = new EncryptAlgorithmSwitch();
                }

                return mUpdater2;
            }
            set
            {
                mUpdater2 = value;
            }
        }
        class EncryptAlgorithmSwitch : ICommand   //this is a RelayCommand
        {/*//***** Class Description   *****/
         //***** Name: EncryptAlgorithmSwitch     *****//
         //***** Description: This class implements a command when a user clicks the Encrypt Algorithm Combobox  *****//
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
            {//Execute Command here

                //TO DO: 1)Link command to the SettingsView Label Box.  ideally click on a Label text and It inserts it's associated view
                //      Needs ability to go back to the HomeScreen as well as always have the ablility to LogOut no matter which view you're at
                //      (will need multiple commands linked to each Settings view Label (i.e. populate ComboBoxes)




            }
            #endregion

        }


    }

}




