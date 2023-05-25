using CommunityToolkit.Maui.Views;

namespace ACLabsApplication;

public partial class MotorValuesPage : ContentPage 
{
	public MotorValuesPage()
	{
		InitializeComponent();     
    }

    public async void GoToSetMotorValuesPageButton_Clicked(Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SetMotorValuesPage());
    }
    private async void GoToHomePageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
   
    private async void InfoButton_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new InfoPopup());
    } 

}