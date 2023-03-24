using CommunityToolkit.Maui.Views;

namespace MauiAppX;

public partial class MainPage : ContentPage
{
   public MainPage()
   {
      InitializeComponent();
   }

   private async void ShowPopupButton_Clicked(object sender, EventArgs e)
   {
      //  var res = await DisplayActionSheet("Test", "Cancel", null, "Gallery","Camera");
        this.ShowPopup(new BarcodeResultsPage());
   }

    private void ShowCenterPopupButton_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new BarcodeResultsPageCenter());
    }

    private void ShowTopPopupButton_Clicked(object sender, EventArgs E)
    {
        this.ShowPopup(new BarcodeResultsPageTop());
    }
    private void ShowLeftPopupButton_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new BarcodeResultsPageLeft());
    }
    private void ShowRightPopupButton_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new BarcodeResultsPageRight());
    }
}

