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
	public partial class Filter : ContentPage
	{
        HomeViewModel vm;
		public Filter ()
		{

            InitializeComponent();
           // InitSearchBar();
            vm = new HomeViewModel();


            listHome.ItemsSource = vm.Homeclasses2;
            listHome.ItemTapped += ListHome_ItemTapped;
            listHome1.ItemsSource = vm.Homeclasses3;

            listHome1.ItemTapped += ListHome_ItemTapped;

            listHome2.ItemsSource = vm.Homeclasses4;
            listHome2.ItemTapped += ListHome_ItemTapped;
            listHome3.ItemsSource = vm.Homeclasses5;
            listHome3.ItemTapped += ListHome_ItemTapped;
            listHome4.ItemsSource = vm.Homeclasses6;
            listHome4.ItemTapped += ListHome_ItemTapped;
            listHome5.ItemsSource = vm.Homeclasses7;
            listHome5.ItemTapped += ListHome_ItemTapped;
            listHome6.ItemsSource = vm.Homeclasses8;
            listHome6.ItemTapped += ListHome_ItemTapped;
            listHome7.ItemsSource = vm.Homeclasses9;
            listHome7.ItemTapped += ListHome_ItemTapped;
        }

        /* private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
         {
             var vm = BindingContext as HomeViewModel;
             var product = e.Item as Product;

             vm.HideorShowProduct(product); 

         }*/
    
   private void ListHome_ItemTapped(object sender, ItemTappedEventArgs e)
   {

       Homeclass item = (Homeclass)e.Item;
       Navigation.PushAsync(new DetailView(item));

   }


        /*
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
           listHome1.ItemsSource = vm.Homeclasses;
           listHome2.ItemsSource = vm.Homeclasses;

       }
       else
       {
           listHome.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome1.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome2.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome3.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome4.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome5.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome6.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));
           listHome7.ItemsSource = vm.Homeclasses.Where(x => x.Detail.ToLower().Contains(filter.ToLower()));

       }
   }*/



    }

}