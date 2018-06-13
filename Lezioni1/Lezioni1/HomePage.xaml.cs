using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lezioni1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            SecondPage p = new SecondPage();
            await this.Navigation.PushAsync(p);
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            menu m = new menu();
            await this.Navigation.PushAsync(m);
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            TestPage t = new TestPage();
            await this.Navigation.PushAsync(t);
        }

    }
}