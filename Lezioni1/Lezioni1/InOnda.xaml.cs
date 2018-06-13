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
	public partial class InOnda : ContentPage
	{
		public InOnda ()
		{
			InitializeComponent ();
		}

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            //HomePage h= new HomePage();
            //await this.Navigation.PopAsync(false);
            await this.Navigation.PopToRootAsync();
            
        }
    }
}