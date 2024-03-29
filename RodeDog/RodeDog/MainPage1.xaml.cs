﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RodeDog
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/pages/login.xaml?action=login", UriKind.Relative));
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/pages/login.xaml?action=register",UriKind.Relative));
        }

       
    }
}