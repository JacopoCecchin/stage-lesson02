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
	public partial class canali : ContentPage
	{
		public canali ()
		{
			InitializeComponent ();
		}

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            InOnda i = new InOnda();
            //Page p = new menu();
            await this.Navigation.PushAsync(i);
        }
    }
}