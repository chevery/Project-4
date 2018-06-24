using KillMyself.Model;
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
	public partial class Settings : ContentPage
	{
        SpeakerViewModel vm;

        public Settings ()
		{


            {
                InitializeComponent();
                vm = new SpeakerViewModel();
                BindingContext = vm;
                listSpeakers.ItemsSource = vm.Speakers;
                listSpeakers.ItemTapped += ListSpeaker_ItemTapped;
            }

            void ListSpeaker_ItemTapped(object sender, ItemTappedEventArgs e)
            {
                Speaker item = (Speaker)e.Item;
                Navigation.PushAsync(new DetailView2(item));
            }
        }
	}
}