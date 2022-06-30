namespace WebView_Crash;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OpenWebViewBtn_Clicked(object sender, EventArgs e)
	{
		var window = new Window()
		{
			Page = new WebView(),
			Title = "WebView Test",
		};

		Application.Current.OpenWindow(window);

		while (Application.Current.Windows.Contains(window))
		{
			await Task.Delay(500);
		}

		// If you close the window using the button at the bottom then this display alert will crash the app
		// Uncomment

		/*
		DisplayAlert("Alert!", "This would cause a bug", "Ok");
		*/
	}
}

