﻿using HULK.ViewModels;
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

namespace HULK.Views
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Page, IHavePassword
    { /*//***** Class Description   *****/
      //***** Name:     *****//
      //***** Description: T  *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****                       *****//     */
        public LoginScreen()
        {
            InitializeComponent();
            DataContext = new LoginScreenViewModel();

        }

        public System.Security.SecureString PasswordView
        {
            get
            {
                return passwordBox.SecurePassword;
            }
        }

    }

   
}

    