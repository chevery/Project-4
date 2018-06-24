using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KillMyself
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailTent : ContentPage
	{
		public DetailTent (Tentoonstellingenclass item)
		{
			InitializeComponent ();
            Title2.Text = item.Title2;
            Webs.Text = item.Webs;
            Webs.TextColor = Color.White;
            ItemDetailTekst.Text = item.Overview;
            Foto.Source = item.Imageurl;
            Title2.HorizontalTextAlignment = TextAlignment.Center;
            Title2.VerticalOptions = LayoutOptions.Start;
            ItemDetailTekst.HorizontalTextAlignment = TextAlignment.Center;
            ItemDetailTekst.VerticalOptions = LayoutOptions.End;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Webs.Text));
        }
    }
}