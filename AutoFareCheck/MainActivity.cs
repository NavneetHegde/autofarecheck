using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AutoFareCalculator;

namespace AutoFareCheck
{
	[Activity (Label = "AutoFareCheck", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			AutoFareCalculator.AutoFareCalculator fareCalculator = new AutoFareCalculator.AutoFareCalculator ();

			// Set our view from the "main" layout resource

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton2);
			EditText editText = FindViewById<EditText> (Resource.Id.textView2);
			TextView resultText = FindViewById<TextView> (Resource.Id.textView3);



			button.Click += delegate {
				var resultFare = fareCalculator.CalculateFare(double.Parse(editText.Text));
				resultText.Text = string.Format ("Your fare is Rs.{0} ", resultFare);
			};
		}
	}
}


