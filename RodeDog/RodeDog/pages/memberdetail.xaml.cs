using System;
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
using Microsoft.Phone.Shell;

namespace RodeDog.pages
{
    public partial class memberdetail : PhoneApplicationPage
    {
        string id;

        public memberdetail()
        {
            InitializeComponent();
        }

        private void bark_Click(object sender, RoutedEventArgs e)
        {
            App.barks_sent.Add(new bark { When = DateTime.Now.ToShortDateString(), From = memname.Text, Pack = packname.Text });
            ShellToast st = new ShellToast();
            st.Title = "Bark Bark:";
            st.Content = "from " + memname.Text;
            st.Show();
            NavigationService.GoBack();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            NavigationContext.QueryString.TryGetValue("id", out id);
            foreach (Pack p in App.my_packs)
            {
                foreach (member m in p.Members)
                {
                    if (m.ID == int.Parse(id))
                    {
                        packname.Text = m.Pack;
                        memname.Text = m.Name;
                    }
                }
            }
            base.OnNavigatedTo(e);
        }
    }
}