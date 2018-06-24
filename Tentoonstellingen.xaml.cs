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
	public partial class Tentoonstellingen : ContentPage
	{
        TentoonstellingenViewModel vm;

		public Tentoonstellingen ()
		{
			InitializeComponent ();
            vm = new TentoonstellingenViewModel();
            listTentoonstellingen.ItemTapped += ListTentoonstellingen_ItemTapped;
            listTentoonstellingen.ItemsSource = vm.Tentoonstellingenclasses;
		}

        private void ListTentoonstellingen_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Tentoonstellingenclass item = (Tentoonstellingenclass)e.Item;
            Navigation.PushAsync(new DetailTent(item));
        }
    }
}