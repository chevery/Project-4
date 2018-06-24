using KillMyself.Model;
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
	public partial class DetailView2 : ContentPage
	{
        public DetailView2(Speaker item)
        {
            InitializeComponent();
            ItemDetailTekst.Text = item.ShortDescription;
            Title.Text = item.SpeakerName;
            Title.HorizontalTextAlignment = TextAlignment.Center;
            ItemDetailTekst.HorizontalTextAlignment = TextAlignment.Center;
            ItemDetailTekst.VerticalOptions = LayoutOptions.Start;

        }
    }
}