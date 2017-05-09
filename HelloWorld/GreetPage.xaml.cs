using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class GreetPage : ContentPage
	{
		public GreetPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("HOLY FUCK", "Kurwa kurwa kurwa", "GTFO");
		}
	}
} 
