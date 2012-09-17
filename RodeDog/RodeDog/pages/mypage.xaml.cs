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
            ObservableCollection<Packs> search_packs = new ObservableCollection<Packs>();
            search_packs.Add(new Packs { Name = "Abrar" });
            search_packs.Add(new Packs { Name = "Denise" });
            search_packs.Add(new Packs { Name = "Victoria" });
            search_packs.Add(new Packs { Name = "David" });
            search_packs.Add(new Packs { Name = "Vak" });
            search_packs.Add(new Packs { Name = "Jutin" });
            search_list.ItemsSource = search_packs;

            ObservableCollection<petstorefeature> petstore_list = new ObservableCollection<petstorefeature>();
            petstore_list.Add(new petstorefeature { Article = new Image { Source = new BitmapImage(new Uri("",UriKind.Relative))} });

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
                petstore_grid.SetValue(Grid.RowProperty, row);
                petstore_grid.SetValue(Grid.ColumnProperty, col++);
                petstore_grid.Children.Add(ps.Article);
                if (col == cols - 1)
                {
                    row++;
                    col = 0;
                }
            }
#endif
        }
    }
}