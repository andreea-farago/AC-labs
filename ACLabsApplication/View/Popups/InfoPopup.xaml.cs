using CommunityToolkit.Maui.Views;
namespace ACLabsApplication;

public partial class InfoPopup : Popup
{
	public InfoPopup()
	{
        InitializeComponent();
    }

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
        this.Close();
    }
}