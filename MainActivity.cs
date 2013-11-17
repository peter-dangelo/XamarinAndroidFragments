using Android.App;
using Android.OS;
using Android.Support.V4.App;

namespace com.xamarin.sample.fragments
{
	[Activity(Label = "Fragments Walkthrough", MainLauncher = true)]
	public class MainActivity : FragmentActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.activity_main);
		}
	}
}
