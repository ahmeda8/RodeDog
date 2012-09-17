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
    public partial class packdetails : PhoneApplicationPage
    {
        string id; 
        public packdetails()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            NavigationContext.QueryString.TryGetValue("id", out id);
            foreach (Pack p in App.search_packs)
            {
                if(p.ID == int.Parse(id))
                {
                    pack_image.Source= new BitmapImage(new Uri(p.PackImage,UriKind.Relative));
                    pack_name.Text = p.Name;
                    break;
                }
            }
            base.OnNavigatedTo(e);
        }

        private void join_btn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Pack p in App.search_packs)
            {
                if (p.ID == int.Parse(id))
                {
                    App.my_packs.Add(p);
                    break;
                }
            }

            NavigationService.GoBack();
        }
    }
}