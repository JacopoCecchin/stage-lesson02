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
	public partial class TestPage : ContentPage
	{
		public TestPage ()
		{
			InitializeComponent ();
		}

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            SecondTestPage p = new SecondTestPage();
            await this.Navigation.PushAsync(p);
        }
    }
}