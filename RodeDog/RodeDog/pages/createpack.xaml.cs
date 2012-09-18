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
using Microsoft.Phone.Tasks;

namespace RodeDog.pages
{
    public partial class createpack : PhoneApplicationPage
    {
        public createpack()
        {
            InitializeComponent();
        }

        private void photo_Click(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask ptsk = new PhotoChooserTask();
            ptsk.ShowCamera = true;
            ptsk.Show();
            ptsk.Completed += new EventHandler<PhotoResult>(ptsk_Completed);
        }

        void ptsk_Completed(object sender, PhotoResult e)
        {
            BitmapImage bi = new BitmapImage();
            bi.SetSource(e.ChosenPhoto);
            img.Source = bi;
        }

        private void invite_Click(object sender, RoutedEventArgs e)
        {
            PhoneNumberChooserTask pct = new PhoneNumberChooserTask();
            pct.Show();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (packname.Text.Length < 1)
            {
                MessageBox.Show("Please enter a pack name");
                return;
            }

            App.my_packs.Add(new Pack { Name = packname.Text });
            NavigationService.GoBack();

        }


        
    }
}