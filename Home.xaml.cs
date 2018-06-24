using KillMyself.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KillMyself
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        HomeViewModel vm;

        public Home()
        {
            InitializeComponent();
            InitSearchBar();
            vm = new HomeViewModel();


            listHome.ItemsSource = vm.Homeclasses;
            listHome.ItemTapped += ListHome_ItemTapped;
        }

        private void ListHome_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Homeclass item = (Homeclass)e.Item;
            Navigation.PushAsync(new DetailView(item));
        }



        void InitSearchBar()
        {
            sb_search.TextChanged += (s, e) => FilterItem(sb_search.Text);
            sb_search.SearchButtonPressed += (s, e) => FilterItem(sb_search.Text);
        }

        private void FilterItem(string filter)
        {
            listHome.BeginRefresh();
            if (string.IsNullOrWhiteSpace(filter))
            {
                listHome.ItemsSource = vm.Homeclasses;
            }
            else
            {
                listHome.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));

            }
        }
    }
}