﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lezioni1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{        
		public SecondPage ()
		{
			InitializeComponent();

            this.TimeLabel.Text = DateTime.Now.ToString();
		}
	}
}