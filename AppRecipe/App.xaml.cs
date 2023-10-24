using AppRecipe.View;

namespace AppRecipe;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new MainPage());
	}
}
