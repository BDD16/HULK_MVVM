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

namespace HULK.Views
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    /// 


    public partial class HomeScreen : Page
    { /*//***** Class Description   *****/
      //***** Name: HomeScreen.xaml.cs    *****//
      //***** Description: Links Viewmodel to the view *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****                       *****//     */
        public HomeScreen()
        {
            InitializeComponent();
            this.DataContext = new HomeScreenViewModel();

        }

    }
}
