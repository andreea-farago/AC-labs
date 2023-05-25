namespace ACLabsApplication;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}
    private async void GoToHomePageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}
