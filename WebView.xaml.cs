namespace WebView_Crash;

public partial class WebView : ContentPage
{
	public WebView()
	{
		InitializeComponent();
	}

	private async void DisplayAlertBugBtn_Clicked(object sender, EventArgs e)
	{
        // This is a workaround. The app will crash if you call DisplayAlert after this happens.
        // Using await makes it work better for some reason

        MainStackLayout.Clear();
        while (MainStackLayout.Children.Count > 0)
        {
            await Task.Delay(1000);
        }
        await Task.Delay(1000);

        Application.Current.CloseWindow(GetParentWindow());
    }
}