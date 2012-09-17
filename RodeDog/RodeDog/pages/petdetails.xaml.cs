using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RodeDog.pages
{
    public partial class petdetails : PhoneApplicationPage
    {
        public petdetails()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string imgsrc;
            NavigationContext.QueryString.TryGetValue("src", out imgsrc);
            pet_image.Source = new BitmapImage(new Uri(imgsrc, UriKind.Relative));
            base.OnNavigatedTo(e);
        }
    }
}