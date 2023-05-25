namespace ACLabsApplication;

public partial class SetMotorValuesPage : ContentPage
{
    public SetMotorValuesPage()
    {
        InitializeComponent();
    }

    private async void GoToMotorValuesPageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MotorValuesPage());
    }
   
}