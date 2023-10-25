namespace AppRecipe.View.Cake;

public partial class CarrotCake : ContentPage
{
	public CarrotCake()
	{
		InitializeComponent();
	}

    private void OnButtonClickedYoutube(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Youtube());
    }
}