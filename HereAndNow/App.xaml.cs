using Xamarin.Forms;
using FreshMvvm;

namespace HereAndNow
{
	public partial class App : Application
	{
		public App()
		{
			SetupIOC();
			InitializeComponent();

			var firstpage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<MainPageModel>();
			var navContainer = new FreshMvvm.FreshNavigationContainer(firstpage);
			MainPage = navContainer;
		}


		void SetupIOC()
		{
			//FreshMvvm.FreshIOC.Container.Register<IDataService, DataService>();
			//FreshMvvm.FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);			
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

