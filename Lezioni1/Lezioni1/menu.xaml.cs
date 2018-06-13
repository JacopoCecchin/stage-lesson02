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
	public partial class menu : ContentPage
	{
		public menu ()
		{
			InitializeComponent ();
		}
        private async void Button1_Clicked(object sender, EventArgs e)
        {
            canali c = new canali();
            await this.Navigation.PushAsync(c);
        }
    }
}