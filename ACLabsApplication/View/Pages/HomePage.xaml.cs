using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ACLabsApplication;

public partial class HomePage : ContentPage
{
	List<Device> devices = new List<Device>();
    public HomePage()
	{
		InitializeComponent();

		Device d1 =new Device()
		{
			Id = 1,
			Name = "JBL TUNE500BT"
		};

		Device d2 = new Device()
		{
			Id = 2,
			Name = "Galaxy A51"
		};

		Device d3 = new Device()
		{
			Id = 3,
			Name = "Huawei P10 lite"
		};

		Device d4 = new Device()
		{
			Id = 4,
			Name = "Iphone"
		};

		Device d5 = new Device()
		{
			Id = 5,
			Name = "JBL Boom Box"
		};

		Device d6 = new Device()
		{
			Id = 6,
			Name = "AJAX Hub BL"
		};

		Device d7 = new Device()
		{
			Id = 7,
			Name = "Poly Blackwire 5220"
		};

		Device d8 = new Device()
		{
			Id = 8,
			Name = "Savi 7320"
		};
		devices.Add(d1);
		devices.Add(d2);
		devices.Add(d3);
		devices.Add(d4);
		devices.Add(d5);
		devices.Add(d6);
		devices.Add(d7);

		MyList.ItemsSource= devices;
	}

	private async void ConnectButton_Clicked(object sender, EventArgs e)
	{
        ConnectButton.IsVisible = false;
        Grid.IsVisible = true;
        
    }

	private async void OnItemSelected_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MotorValuesPage());
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        string text = "Connected successfully";
        ToastDuration duration = ToastDuration.Long;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show(cancellationTokenSource.Token);
    }

}