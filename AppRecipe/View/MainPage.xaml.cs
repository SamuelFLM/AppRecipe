using AppRecipe.View.Cake;

namespace AppRecipe.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        DateTime data = DateTime.Now;
        DataActually.Text = data.ToString("D");
    }

    private void OnButtonClickedCerrotCakeRecipe(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CarrotCake());
    }
}