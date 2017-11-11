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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using HULK.ViewModels;
using HULK.Views;

namespace HULK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { /*//***** Partial Class Description   *****/
      //***** Name:MainWindow.xaml.cs     *****//
      //***** Description: Shell Window  *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****    *****//
      //*****                       *****//     */

        private ResourceDictionary myresourcedictionary;
        public event PropertyChangedEventHandler PropertyChanged;
        public MainWindow()
        {
           InitializeComponent();
          

            //1) Load in the Resource Dictionary which connects the Views to their View Models
             myresourcedictionary = new ResourceDictionary();
             System.Uri resourceLocater = new System.Uri("/HULK;component/Views/ResourceDictionary.xaml", System.UriKind.Relative);
             myresourcedictionary.Source = resourceLocater;

            //2) Load into Main Window the LoginScreen viewModel
            LoginScreenViewModel LoginScreenViewModel = new LoginScreenViewModel();
            Content = LoginScreenViewModel;
            this.DataContext = Content;

            //3) Display the Login View in the Main Window.
            LoadView("Views/LoginScreen.xaml");
             this.Show();
           
        }


        Object _content;
        public object ContentView
        {
            get { return _content; }
            set
            {
                _content = value;
                NotifyPropertyChanged("ContentView");
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }

        public void LoadView(string viewlocation)
        {
            System.Uri resourceLocater = new System.Uri("/HULK;component/" + viewlocation, System.UriKind.Relative);

            System.Windows.Application.LoadComponent(this, resourceLocater);

        }
    }
}