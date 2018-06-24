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
	public partial class DetailView : ContentPage
	{
		public DetailView (Homeclass item)
		{
			InitializeComponent ();
            Title2.Text = item.Title2;
            Title2.HorizontalTextAlignment = TextAlignment.Center;
            Opening.Text = item.Openings;
            Opening.HorizontalTextAlignment = TextAlignment.Center;
            Webs.Text = item.Webs;
            Webs.TextColor = Color.White;
            ItemDetailTekst.Text = item.Overview;
            Foto.Source = item.Imageurl;
            ItemDetailTekst.HorizontalTextAlignment = TextAlignment.Center;
            ItemDetailTekst.VerticalOptions = LayoutOptions.Start;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Webs.Text));
        }
    }
}