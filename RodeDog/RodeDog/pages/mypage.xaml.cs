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
using Microsoft.Phone.Controls.Maps;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RodeDog
{
    public partial class mypage : PhoneApplicationPage
    {
        public mypage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
#if DEBUG
            
            search_list.ItemsSource = App.search_packs;

            ObservableCollection<petstorefeature> petstore_list = new ObservableCollection<petstorefeature>();
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/bear.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/bird.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bird.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/chicken.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/chicken.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/cow.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/cow.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dog.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dog1.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dog2.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dog3.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dog4.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dog5.png", UriKind.Relative)) }, Name = "/RodeDog;component/assets_big/bear.png" });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/dolphin.png", UriKind.Relative)) } });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/elephant.png", UriKind.Relative)) } });
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("/RodeDog;component/assets_big/lion.png", UriKind.Relative)) } });

            int cols = 3;
            double rows = Math.Ceiling((double)(petstore_list.Count / cols));
            for (int i = 0; i < rows; i++)
            {
                petstore_grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(150) });
                if (i < cols)
                    petstore_grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(150) });
            }

            int row = 0;
            int col = 0;
            foreach (petstorefeature ps in petstore_list)
            {
                ps.Article.SetValue(Grid.RowProperty, row);
                ps.Article.SetValue(Grid.ColumnProperty, col++);
                ps.Article.Width = 100;
                ps.Article.Height = 100;
                ps.Article.Tag = ps.Name;
                ps.Article.Tap += new EventHandler<GestureEventArgs>(Article_Tap);
                petstore_grid.Children.Add(ps.Article);
                
                if (col == cols)
                {
                    row++;
                    col = 0;
                }
            }

            mypacks_list.ItemsSource = App.my_packs;
#endif
        }

        void Article_Tap(object sender, GestureEventArgs e)
        {
            Image src = (Image)sender;
            string imgsrc = src.Tag.ToString();
            imgsrc = HttpUtility.UrlEncode(imgsrc);
            NavigationService.Navigate(new Uri("/pages/petdetails.xaml?src="+imgsrc,UriKind.Relative));
        }

        private void search_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pack p = search_list.SelectedItem as Pack;
            
            if (search_list.SelectedIndex > -1)
            {
                NavigationService.Navigate(new Uri("/pages/packdetails.xaml?id="+p.ID,UriKind.Relative));
            }
        }
    }
}